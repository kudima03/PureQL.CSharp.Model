# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

All `dotnet` commands must be run from the `./src` directory.

```bash
dotnet restore
dotnet build --no-restore -warnaserror
dotnet format --verify-no-changes             # check code style (CI enforces this)
dotnet format                                  # auto-fix code style
dotnet test --no-build --verbosity normal      # run tests
dotnet pack --configuration Release -p:Version=<version> --output .
```

CI additionally passes `-p:AssemblyVersion` (pinned to the major) and `-p:FileVersion`; see `.github/workflows/publish-nuget.yml`.

## Architecture

This is a **model-only NuGet library** — no I/O, no implementations, no database access. It defines the abstract syntax tree (AST) that other PureQL packages use to represent queries.

**Spec parity:** the model mirrors PureQL specification `0.1.0-preview.2.0.1` (`PureQL-Specification.json` in `kudima03/PureQL-Specification`). Every operator signature `$defs` entry maps to a record named by PascalCasing its key (`add.integer.nullable@row` → `AddIntegerNullableRow`, `equal.string@group` → `EqualStringGroup`), and every position `<type>[.nullable]@<ctx>` to a union of the same name (`decimal.nullable@row` → `DecimalNullableRow`), the names the TypeScript model (`PureQL.TypeScript.Model`) uses. Operators with a single signature (`and`, `or`, `not`, `count`, `any`, `all`) map from `<operator>@<ctx>` (`AndRow`, `CountGroup`); `equal`, `notEqual`, `in` and comparisons have a record per operand family under the `<operator>@<ctx>` union (`EqualRow` = `EqualDecimalRow` | … | `EqualUuidRow`). `declares.*`, `accepts.*`, `value.*`, `leaf@*`, `operator@*` and the other multi-signature `<operator>@<ctx>` dispatchers are validation helpers and have no C# type.

**Root types:** `PureQLQuery` = `MainGroupedQuery | MainPlainQuery | MainTotalQuery` (dispatch on `groupBy`, then `aggregate`); subqueries use `Query` = `GroupedQuery | PlainQuery | TotalQuery`. `From` / `Join` are unions of an entity and a subquery form; a join's kind is `JoinKind Kind`. Plain and grouped queries have `IEnumerable<string>? DistinctBy`; a total query has `Aggregate` columns and no `OrderBy`, `DistinctBy`, `Pagination` or `Having`.

**Contexts:** each expression exists per context — `RowExpressions` (`where`, `join.on`, group keys, aggregate selector / predicate), `ProjectionExpressions` (`select` / `orderBy` of a plain query), `GroupExpressions` (`select` / `having` / `orderBy` with `groupBy`), `TotalExpressions` (`aggregate` of a total query: parameters, literals and aggregates, no fields or keys).

**Declared types:** every node declares an exact type, given by its record. Every operator record implements `IOperator` (`IType Type`), as leaves, select items and group keys expose `IType Type`. Per context and per type (`integer`, `decimal`, `string`, `boolean`, `date`, `time`, `datetime`, `uuid`, each non-null and nullable) there is:
- an **exact union** of everything declaring exactly that type: the leaves of the type, then its operator families. It is named `Exact{T}{Ctx}` (`ExactDecimalRow`, `ExactIntegerNullableGroup`), except where it coincides with the position (below).
- a **position**, `{T}{Ctx}` / `{T}Nullable{Ctx}`: the union of the exact unions whose type the position accepts (`T → T?`, `integer → decimal`), in the order `T`, `T?`, `integer`, `integer?`: `DecimalNullableRow` = `ExactDecimalRow | ExactDecimalNullableRow | IntegerRow | ExactIntegerNullableRow`. A position that accepts one type is that exact union (`IntegerRow`, `StringRow`, …, `UuidRow`, non-null only).

Operands are typed by the position the schema refers to; group keys and select columns take the exact union, so their `Type` is the type their expression declares. `orderBy` items take `Expr{Ctx}` (`expr@<ctx>`): the union of the seven nullable positions.

**Union grouping:** OneOf supports at most 9 cases, so exact unions group their operators by family: `Logical{Ctx}`, `Comparison{Ctx}` (→ `Equal{Ctx}`, `NotEqual{Ctx}`, `In{Ctx}`, `GreaterThan{Ctx}`, …), `Arithmetic{T}{Ctx}`, `Rounding{T}{Ctx}`, `Difference{T}{Ctx}`, `Conditional{T}{Ctx}`, `Aggregate{T}{Ctx}`, each holding the members that declare `T`. A family with one member is a direct case. Cases follow the schema's operator order: leaves (field or key, param, literal), then add, subtract, multiply, divide, integerDivide, modulo, floor, ceiling, round, concat, dateAddDays, dateDiffDays, timeAddSeconds, timeDiffSeconds, datetimeAddSeconds, datetimeDiffSeconds, and, or, not, equal, notEqual, in, greaterThan, lessThan, greaterThanOrEqual, lessThanOrEqual, if, coalesce, count, sum, average, min, max, any, all. `GroupKey`, `SelectItemGroup`, `SelectItemProjection` and `SelectItemTotal` split into `…NonNullable` / `…Nullable` unions of the 8 per-type records.

**Records:** operator properties use the schema's property names (`Values`, `Left`, `Right`, `Operand`, `Digits`, `Condition`, `Then`, `Else`, `Conditions`, `List`, `Selector`, `Predicate`); `operator` and `type` are implied by the record type. Aggregate `over` is `AggregateOver Over = AggregateOver.Group` in group context only (`Group` is the default and is never written). In projection and group context, `average` / `min` / `max` have a non-null signature with a non-null selector and no `Predicate`, and a nullable one with an optional `Predicate`; in total context they are only nullable. Literal CLR types: `long`, `decimal`, `string`, `bool`, `DateOnly`, `TimeOnly`, `DateTimeOffset`, `Guid`; nullable literals (`LiteralIntegerNullable`) are the typed `null` and carry no value. Group keys are `GroupKey{T}(alias, expression)` and are referenced by alias (`Key{T}(string key)`). Rules the schema checks beyond types (exact declared types such as `AddDecimal…` needing a `decimal` operand, `and` / `or` with two conditions, at most one non-null `coalesce` operand, `pagination` requiring `orderBy`, literal values the CLR type holds but the schema rejects: a `TimeOnly` or `DateTimeOffset` finer than a microsecond, a `DateTimeOffset` not in UTC) are not enforced by the model.

Every discriminated union is implemented with [OneOf](https://github.com/mcintyre321/OneOf) (`OneOfBase<…>`). Each concrete case type is a separate sealed record.

**Namespaces and folders map 1:1:** root (queries, `From`, `Join`, `Subquery`, `Pagination`, `OrderItem*`, `IOperator`, enums), `Types`, `Fields`, `Parameters`, `Literals`, `Keys`, `Lists`, `RowExpressions`, `ProjectionExpressions`, `GroupExpressions`, `TotalExpressions`, `GroupKeys`, `SelectItems`.

**Updating to a new spec version:** the expression types were generated from the schema with a one-off script that is not part of the repository; the rules above are what it implements. Small spec changes are applied by hand following the same rules; compare with the TypeScript model, which regenerates its types from the pinned schema tag. Generated files are formatted with CSharpier, then `dotnet format` (which CI checks).

**Multi-targeting:** net6.0, net7.0, net8.0, net9.0, net10.0. All types must remain AOT-compatible (`IsAotCompatible = true`).

**Package validation:** `EnablePackageValidation = true` with `PackageValidationBaselineVersion = 0.1.0-preview.10.0.0`. Breaking API changes fail the build.

**Publishing:** triggered by pushing a semver tag (e.g. `1.2.3`). The tag becomes the `PackageVersion`. The workflow publishes to both GitHub Packages and NuGet.org.

## Tests

There is a test project (`PureQL.CSharp.Model.Tests`) using xunit, targeting net10.0 only. `SampleQueryTests` builds specification samples; `ModelShapeTests` checks every exported type by reflection (union case indices, record properties, declared types, and that every exact union and position holds exactly the declared types it accepts). Run from `./src`:

```bash
dotnet test --no-build --verbosity normal --logger trx --collect:"XPlat Code Coverage"
```

CI enforces a 0% minimum and 99% warning threshold for code coverage.

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
