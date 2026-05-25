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
dotnet pack --configuration Release -p:PackageVersion=<version> --output .
```

## Architecture

This is a **model-only NuGet library** — no I/O, no implementations, no database access. It defines the abstract syntax tree (AST) that other PureQL packages use to represent queries.

**Central type:** `Query` (sealed record) assembles all query clauses: `FromExpression`, `IEnumerable<SelectExpression>`, `BooleanReturning?` (WHERE/HAVING), `IEnumerable<Join>?`, `IEnumerable<Field>?` (GROUP BY / ORDER BY), and `Pagination?`.

**Composition model:**

- `SelectExpression` wraps `SingleValueReturning | ArrayReturning`
- `BooleanReturning` wraps `BooleanParameter | BooleanScalar | Equality | BooleanOperator | Comparison`
- Typed returnings (e.g. `NumberReturning`) wrap the matching `Parameter` and `Scalar` types
- `Comparison` wraps typed comparisons (Number, String, Date, DateTime, Time)
- `Equality` wraps `SingleValueEquality | ArrayEquality`, each with typed variants per scalar kind
- `BooleanOperator` wraps `AndOperator | OrOperator | NotOperator`

Every discriminated union is implemented with [OneOf](https://github.com/mcintyre321/OneOf) (`OneOfBase<…>`). Each concrete case type is a separate sealed record.

**Namespaces and folders map 1:1:** `Aggregates`, `Arithmetics`, `ArrayEqualities`, `ArrayParameters`, `ArrayReturnings`, `ArrayScalars`, `ArrayTypes`, `BooleanOperations`, `Comparisons`, `Equalities`, `Fields`, `Parameters`, `Returnings`, `Scalars`, `Types`.

**Fields** (`IField` — Entity, Field, IType) are used only for GROUP BY and ORDER BY. SELECT expressions use Returnings (parameter/scalar unions), not field types directly.

**Multi-targeting:** net6.0, net7.0, net8.0, net9.0, net10.0. All types must remain AOT-compatible (`IsAotCompatible = true`).

**Package validation:** `EnablePackageValidation = true` with `PackageValidationBaselineVersion = 0.1.0-preview.10.0.0`. Breaking API changes fail the build.

**Publishing:** triggered by pushing a semver tag (e.g. `1.2.3`). The tag becomes the `PackageVersion`. The workflow publishes to both GitHub Packages and NuGet.org.

## Tests

There is a test project (`PureQL.CSharp.Model.Tests`) using xunit, targeting net10.0 only. Run from `./src`:

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
