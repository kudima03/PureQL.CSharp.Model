# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

All `dotnet` commands must be run from the `./src` directory. The projects need the .NET 11 SDK (C# 15 unions).

```bash
dotnet restore
dotnet build --no-restore -warnaserror
dotnet run --project PureQL.CSharp.Model.Generator   # regenerate the model (fetches the pinned schema)
dotnet run --project PureQL.CSharp.Model.Generator -- --normalized <file>   # also write the normalized schema
dotnet format --verify-no-changes             # check code style (CI enforces this)
dotnet format                                  # auto-fix code style
dotnet test --no-build --verbosity normal      # run tests
dotnet pack --configuration Release -p:Version=<version> --output .
```

CI additionally passes `-p:AssemblyVersion` (pinned to the major) and `-p:FileVersion`; see `.github/workflows/publish-nuget.yml`.

## Architecture

This is a **model-only NuGet library** — no I/O, no implementations, no database access. It defines the abstract syntax tree (AST) that other PureQL packages use to represent queries.

**Generated:** every `.cs` file of `PureQL.CSharp.Model` is written by `PureQL.CSharp.Model.Generator` from PureQL specification `0.1.0-preview.3.0.0` (`Program.SchemaTag`; `PureQL-Specification.json` in `kudima03/PureQL-Specification`). Never edit the model by hand: change the generator and regenerate (`--schema <file>` generates from a local copy). The generator deletes and rewrites every `.cs` file of the project; CI regenerates and fails on any difference. Its output already satisfies `dotnet format`.

**Generator:** `SchemaNormalizer` is a function-for-function port of `scripts/normalize-schema.ts` of the TypeScript model (`PureQL.TypeScript.Model`): it resolves the schema's type-directed conditionals into one object per exact declared type and unions of them, and must stay equivalent to it (its JSON output, written with `--normalized`, is identical to the TypeScript one). Keep the two in sync when either changes; unknown schema patterns throw. For specification `0.1.0-preview.3.0.0` the C# normalizer was extended first, and the TypeScript one (still at `0.1.0-preview.2.0.1`) has to be ported to match: section dispatches (`operator.arithmetic@row`) spliced like `operator@row`; one-signature operators with plain rules next to their shape; signatures split by their operand's family (`asString.decimal.string@row`) or by the presence of an operand (`round.withDigits.integer@row`), their rule definitions consumed; a `false` property rule (a family without `zone`) forbidding it; a disjunction across operands resolved when every other operand is forbidden; value rules (`zoneName`, regex and fraction patterns) validation-only; literal-or-parameter definitions (`regexPattern`, `offset`, `cell`); key dispatches on an `anyOf` of keys (set operations); `oneOf` dependent schemas, a trigger that cannot be present left out of the name, and `minProperties: 1` requiring the one property left (`WindowWithoutFrameWithoutRange`); the `range` rule of a window split by the type of its sort key into derived `orderItem.<type>@row` objects; type groups only for context dispatches (`expr@row`, not `cell`). `ModelEmitter` turns the normalized schema into C#:
- every closed object → a sealed record named by its title, the `$defs` key in PascalCase (`add.integer.nullable@row` → `AddIntegerNullableRow`); the names are the TypeScript model's. A split signature keeps its declared type last: `YearDateIntegerRow`, `AsStringDecimalStringNullableRow`, `RoundWithDigitsIntegerRow`. Query variants come from the schema's dependencies (`MainPlainQueryWithPagination`, `WindowWithFrame`), `from` / `join` / `orderBy` item / subquery / set operation variants from its `oneOf` (`FromEntity`, `OrderItemProjectionColumn`, `SubqueryRows`, `CombinedQueryUnionAll`). A list's anonymous members are `ListLiteral{T}`, `ListParam{T}` and `ListSubqueryColumn{T}[Nullable]` (one record per declared type of the column); any other anonymous object is named after its owner and its only property (`DistanceDateDays`), and a constant member (`"all"`) is an empty record named after it (`All`).
- every union → a **flat** `public readonly union`: C# unions only convert from their own cases, so a union lists the records it reaches, never another union (`DecimalNullableRow` holds `AddIntegerRow`, not `DeclaresIntegerRow`). Unions with the same records are one type, named after the definition that is not a `declares.*` group (`integer@row` and `declares.integer@row` are `IntegerRow`); several such definitions each keep their own name (`RegexPattern` and `Separator`, both `LiteralString | ParamString`). An inline `anyOf` of `declares.*` groups is named after their types (`IntegerNullableOrDecimalNullableRow`), any other after its property (`PaginationSkip`, `DistanceDateDaysDays`). Only unions reachable from `PureQLQuery` are emitted.
- `operator` and `type` are implied by the record: `operator` makes it an `IOperator`, `type` becomes `IType Type => new TypeX()`. A nullable literal (`value: null`) has no `Value`. Forbidden properties (`false`) are left out.
- properties keep the schema's names (`Values`, `Left`, `Param`, `Selector`, …) and order; the constructor takes the required ones first, then the optional ones (`T? x = null`). Enums: `kind` → `JoinKind`, `direction` → `SortDirection` (absent = `Asc`), `over` → `AggregateOver` (absent = `Group`), `form` → `NormalizationForm` (required), `mode` → `RoundingMode` (absent = `HalfAwayFromZero`). A `{ const: true }` property (`distinct`) is a `bool` defaulting to `false`. Literal CLR types: `long`, `decimal`, `string`, `bool`, `DateOnly`, `TimeOnly`, `DateTimeOffset`, `Guid`.
- interfaces by properties: `IOperator`, `IField` (`source`, `field`), `ISubqueryColumn` (`subquery`, `field`), `IParameter` (`param`), `IKey` (`key`), `ILiteral` (`value`); every typed record has one.

**Root types:** `PureQLQuery` = the main query variants (combined, grouped, total, plain); subqueries, set operands and recursive seeds use `Query`. `Subquery` = `SubqueryQuery` | `SubqueryRows` | `SubqueryRecursive` (`Recursion(seed, NextQuery next, maxDepth)`). `pagination` requires `orderBy` (`…WithPagination`); in a subquery `orderBy` requires `pagination` or `distinctBy` (`…WithoutPaginationWithOrderBy` has a required `DistinctBy`). A total query has `Aggregate` columns and no `OrderBy`, `DistinctBy`, `Pagination` or `Having`.

**Contexts:** each expression exists per context — `RowExpressions` (`where`, `join.on`, group keys, aggregate selector / predicate / `orderBy`, windows, `previous` / `next` operands, `PlainNextQuery.Select`), `ProjectionExpressions` (`select` / `orderBy` of a plain query; windows and ranking only here), `GroupExpressions` (`select` / `having` / `orderBy` with `groupBy`, `GroupedNextQuery`), `TotalExpressions` (`aggregate` of a total query). Positions `{T}[Nullable]{Ctx}` hold every expression whose declared type they accept (`T → T?`, `integer → decimal`); `Expr{Ctx}` holds them all and types group keys, select columns and order items; `Declares{T}{Ctx}` and `{A}Or{B}{Ctx}` are the narrower operands the schema asks for.

Rules the schema checks beyond types (a multi-operand operator's exact declared type, a nullable result needing one of several operands nullable, `and` / `or` with two conditions, at most one non-null `coalesce` operand, `minItems` / `minProperties`, patterns and literal values such as a zone name, a regex, a fraction or an offset, a `TimeOnly` or `DateTimeOffset` finer than a microsecond, a `DateTimeOffset` not in UTC) are not enforced by the model.

**Namespaces and folders map 1:1:** root (queries, `From`, `Join`, `Subquery`, `Pagination`, `GroupKey`, `SelectItem*`, `OrderItem*`, `IOperator`, enums), `Types`, `Fields`, `Parameters`, `Literals`, `Keys`, `Lists`, `RowExpressions`, `ProjectionExpressions`, `GroupExpressions`, `TotalExpressions`.

**Updating to a new spec version:** bump `Program.SchemaTag`, port any change of the TypeScript normalizer, regenerate, review the diff, and update the tests. When the schema uses a pattern the normalizer or emitter does not handle, they throw: extend them rather than editing output. To check the positions against the schema itself, build an instance of every expression record from the normalized schema, validate it with the specification, and probe each operand with leaves of every declared type: no position may reject what the schema accepts, and what it accepts beyond the schema must be one of the rules above.

**Target framework:** net11.0 only (C# 15 unions need .NET 11's `UnionAttribute` / `IUnion`). The model must remain AOT-compatible (`IsAotCompatible = true`).

**Package validation:** enabled against `PackageValidationBaselineVersion` `0.1.0-preview.14.1.0`.

**Publishing:** triggered by pushing a semver tag (e.g. `1.2.3`). The tag becomes the `PackageVersion`. The workflow publishes to both GitHub Packages and NuGet.org.

## Tests

There is a test project (`PureQL.CSharp.Model.Tests`) using xunit, targeting net11.0. `SampleQueryTests` builds specification samples (`samples/valid/NNN_*.json`); `ModelShapeTests` checks every exported type by reflection (unions hold each case as their `Value` and never nest, records keep their constructor arguments and default optional ones to absent, nodes declare the type their name says, operands of a family declare it, rounding to a whole number takes a decimal, range windows sort by the type of their distances, and every position, `Declares*` and `…Or…` union holds exactly the expressions of `Expr{Ctx}` whose declared type it accepts). `OperatorsDeclareTheTypeInTheirName` lists every operator of the schema: add new ones there. Run from `./src`:

```bash
dotnet test --no-build --verbosity normal --logger trx --collect:"XPlat Code Coverage"
```

CI enforces a minimum and a 99% warning threshold for code coverage.

## Code Style

Enforced via `.editorconfig` and `dotnet format --verify-no-changes` in CI. Non-obvious rules:

- No `var` — always use explicit types (`csharp_style_var_*` = false)
- No expression-bodied methods or constructors; expression bodies allowed only on properties, indexers, and accessors
- `new T()` is preferred over target-typed `new()` when the type is not apparent (`csharp_style_implicit_object_creation_when_type_is_apparent = false`)
- File-scoped namespaces required (`csharp_style_namespace_declarations = file_scoped`)
- `using` directives must be outside the namespace
- Max line length: 90 characters
- Private fields: `_camelCase`; no non-private instance fields

## Commit Messages

Do not mention Claude or AI assistance in commit messages.
