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

**Spec parity:** the model mirrors PureQL specification `0.1.0-preview.1.0.0` (`PureQL-Specification.json` in `kudima03/PureQL-Specification`). Every schema `$defs` entry maps to a C# type named by PascalCasing its key (`add.integer@row` → `AddIntegerRow`), the same names the TypeScript model (`PureQL.TypeScript.Model`) uses. `guarded.*` and `probe.*` defs are validation helpers and have no C# type.

**Root types:** `PureQLQuery` = `MainGroupedQuery | MainPlainQuery` (dispatch on `groupBy`); subqueries use `Query` = `GroupedQuery | PlainQuery`. `From` / `Join` are unions of an entity and a subquery form.

**Contexts:** each expression exists per context — `RowExpressions` (`where`, `join.on`, group keys, aggregate selector / predicate), `ProjectionExpressions` (`select` / `orderBy` without `groupBy`), `GroupExpressions` (`select` / `having` / `orderBy` with `groupBy`). Per context there is a value union for each of `integer`, `decimal`, `string`, `boolean`, `date`, `time`, `datetime`, `uuid` and its nullable form (`IntegerRow`, `DecimalNullableGroup`, …), with exactly the members the schema lists.

**Union grouping:** OneOf supports at most 9 cases, so value unions group their members by operator family: leaf unions `FieldAs{T}`, `ParamAs{T}`, `LiteralAs{T}`, `KeyAs{T}` (in the leaf namespaces), then `Logical{Ctx}`, `Comparison{Ctx}` (→ `Equal{Ctx}`, `NotEqual{Ctx}`, `In{Ctx}`, `GreaterThan{Ctx}`, …), `Arithmetic{T}{Ctx}`, `Rounding{T}{Ctx}`, `Difference{T}{Ctx}`, `Conditional{T}{Ctx}`, `Aggregate{T}{Ctx}`. A family with one member is a direct case. Family unions shared by `T` and `T?` keep the non-nullable name. `GroupKey`, `SelectItemGroup` and `SelectItemProjection` split into `…NonNullable` / `…Nullable` unions of the 8 per-type records.

**Records:** operator properties use the schema's property names (`Values`, `Left`, `Right`, `Value`, `Digits`, `Condition`, `Then`, `Else`, `Conditions`, `List`, `Selector`, `Predicate`); `operator` is implied by the record type. Aggregate `over` is `AggregateOver Over = AggregateOver.Group` where the schema allows both values and is omitted where it allows one. Literal CLR types: `long`, `decimal`, `string`, `bool`, `DateOnly`, `TimeOnly`, `DateTimeOffset`, `Guid`; nullable literals (`LiteralIntegerNullable`) are the typed `null` and carry no value. Leaves, select items and group keys expose `IType Type`.

Every discriminated union is implemented with [OneOf](https://github.com/mcintyre321/OneOf) (`OneOfBase<…>`). Each concrete case type is a separate sealed record.

**Namespaces and folders map 1:1:** root (queries, `From`, `Join`, `Subquery`, `Pagination`, `OrderItem*`, enums), `Types`, `Fields`, `Parameters`, `Literals`, `Keys`, `Lists`, `RowExpressions`, `ProjectionExpressions`, `GroupExpressions`, `GroupKeys`, `SelectItems`.

**Updating to a new spec version:** the expression types were generated from the schema with a one-off script that is not part of the repository; the rules above are what it implements. Small spec changes are applied by hand following the same rules; compare with the TypeScript model, which regenerates its types from the pinned schema tag.

**Multi-targeting:** net6.0, net7.0, net8.0, net9.0, net10.0. All types must remain AOT-compatible (`IsAotCompatible = true`).

**Package validation:** `EnablePackageValidation = true` with `PackageValidationBaselineVersion = 0.1.0-preview.10.0.0`. Breaking API changes fail the build.

**Publishing:** triggered by pushing a semver tag (e.g. `1.2.3`). The tag becomes the `PackageVersion`. The workflow publishes to both GitHub Packages and NuGet.org.

## Tests

There is a test project (`PureQL.CSharp.Model.Tests`) using xunit, targeting net10.0 only. `SampleQueryTests` builds specification samples; `ModelShapeTests` checks every exported type by reflection (union case indices, record properties, declared types). Run from `./src`:

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
