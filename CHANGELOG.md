# Changelog

All notable changes to PureQL.CSharp.Model are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).
Versioning mirrors the PureQL specification with a `-csharp.N` suffix where needed.

---

## [Unreleased] — spec 0.1.0-preview.0.5.0

Brings the C# model fully in line with PureQL specification versions
`0.1.0-preview.0.2.0` through `0.1.0-preview.0.5.0`.

### Added — spec 0.1.0-preview.0.2.0

Per-row predicate family (`each*`), returning `BooleanArrayReturning`:

- **`EachEquality`** — `eachEqual` for all seven comparable types
  (`EachBooleanEquality`, `EachNumberEquality`, `EachStringEquality`,
  `EachDateEquality`, `EachTimeEquality`, `EachDateTimeEquality`,
  `EachUuidEquality`).
- **`EachComparison`** — `eachGreaterThan`, `eachLessThan`,
  `eachGreaterThanOrEqual`, `eachLessThanOrEqual` for numeric, string,
  date, datetime, and time types. Operator values live in
  `EachComparisonOperator` enum.
- **`EachAndOperator`**, **`EachOrOperator`**, **`EachNotOperator`** —
  element-wise boolean composition over `BooleanArrayReturning` operands.

### Changed — spec 0.1.0-preview.0.2.0

- **`BooleanArrayReturning`** extended with `EachComparison`,
  `EachEquality`, `EachAndOperator`, `EachOrOperator`, `EachNotOperator`.
- **`Join.On`** changed from `BooleanReturning` to
  `OneOf<BooleanReturning, BooleanArrayReturning>`.
- **`Query.Where`** changed from `BooleanReturning?` to
  `OneOf<BooleanReturning, BooleanArrayReturning>?`.

### Added — spec 0.1.0-preview.0.3.0

Per-row numeric arithmetic, returning `NumberArrayReturning`:

- **`EachArithmetic`** union — `EachAdd`, `EachSubtract`, `EachMultiply`,
  `EachDivide`. Each accepts
  `IEnumerable<OneOf<NumberReturning, NumberArrayReturning>>` (`minItems: 2`).

Per-row date math:

- **`EachDateAddDays`** — adds N days per row; left is
  `date | dateArray`, right is `number | numberArray` →
  `DateArrayReturning`.
- **`EachDateDiffDays`** — date difference in days; both operands are
  `date | dateArray` → `NumberArrayReturning`.

Per-row datetime math:

- **`EachDateTimeAddSeconds`** — adds N seconds per row →
  `DateTimeArrayReturning`.
- **`EachDateTimeDiffSeconds`** — datetime difference in seconds →
  `NumberArrayReturning`.

Per-row time math:

- **`EachTimeAddSeconds`** — adds N seconds per row →
  `TimeArrayReturning`.
- **`EachTimeDiffSeconds`** — time difference in seconds →
  `NumberArrayReturning`.

### Changed — spec 0.1.0-preview.0.3.0

- **`NumberArrayReturning`** extended with `EachArithmetic`,
  `EachDateDiffDays`, `EachDateTimeDiffSeconds`, `EachTimeDiffSeconds`.
- **`DateArrayReturning`** extended with `EachDateAddDays`.
- **`TimeArrayReturning`** extended with `EachTimeAddSeconds`.
- **`DateTimeArrayReturning`** extended with `EachDateTimeAddSeconds`.

### Changed — spec 0.1.0-preview.0.4.0

- `integer_equality` → `number_equality` rename in the JSON schema is
  already reflected in the existing `NumberEquality` C# class. No code
  change required.

### Added — spec 0.1.0-preview.0.5.0

- **`OrderByItem`** — wraps a `Field` reference and an optional
  `SortDirection` (`Asc` | `Desc`, default `Asc`).
- **`SortDirection`** enum with values `Asc` and `Desc`.

### Changed — spec 0.1.0-preview.0.5.0

- **`Query.OrderBy`** changed from `IEnumerable<Field>?` to
  `IEnumerable<OrderByItem>?`. Bare field references in `orderBy` must
  be wrapped in `OrderByItem`.

### Fixed

- **`NumberReturning`** now includes `Arithmetic`, `NumberAggregate`, and
  `Count`, matching the `numericReturning` definition in the spec.
- **`DateReturning`** now includes `DateAggregate`.
- **`TimeReturning`** now includes `TimeAggregate`.
- **`DateTimeReturning`** now includes `DateTimeAggregate`.
- **`StringReturning`** now includes `StringAggregate`.

---

## [0.1.0-preview.0.1.0] — spec 0.1.0-preview.0.1.0

Initial release aligned with PureQL specification `0.1.0-preview.0.1.0`.

### Added

- Core query record `Query` with `From`, `SelectExpressions`, `Where`,
  `Join`, `GroupBy`, `Having`, `OrderBy`, `Pagination`.
- Complete scalar type system: `StringScalar`, `NumberScalar`,
  `BooleanScalar`, `NullScalar`, `DateScalar`, `TimeScalar`,
  `DateTimeScalar`, `UuidScalar`.
- Array scalar variants: `StringArrayScalar`, `NumberArrayScalar`, etc.
- Typed fields: `StringField`, `NumberField`, `BooleanField`, `DateField`,
  `TimeField`, `DateTimeField`, `UuidField`. `Field` union wraps all.
- Typed parameters and array parameters.
- `FromExpression` (entity + alias), `Pagination` (skip + take).
- `SelectExpression` — either `SingleValueReturning` or `ArrayReturning`
  with optional alias.
- Typed returnings: `BooleanReturning`, `NumberReturning`,
  `StringReturning`, `DateReturning`, `TimeReturning`, `DateTimeReturning`,
  `UuidReturning`. Array variants: `BooleanArrayReturning`,
  `NumberArrayReturning`, etc.
- Single-value arithmetic: `Add`, `Subtract`, `Multiply`, `Divide`
  wrapped in `Arithmetic`.
- Boolean operators: `AndOperator`, `OrOperator`, `NotOperator`.
- Single-value equalities: `BooleanEquality`, `NumberEquality`,
  `StringEquality`, `DateEquality`, `TimeEquality`, `DateTimeEquality`,
  `UuidEquality` wrapped in `SingleValueEquality`.
- Array equalities: `BooleanArrayEquality`, `NumberArrayEquality`, etc.
  wrapped in `ArrayEquality`.
- Single-value comparisons: `NumberComparison`, `StringComparison`,
  `DateComparison`, `TimeComparison`, `DateTimeComparison`. Operator values
  in `ComparisonOperator` enum.
- Aggregates: `Count`, `NumberAggregate` (`Sum`, `Min`, `Max`,
  `Average`), `StringAggregate`, `DateAggregate`, `TimeAggregate`,
  `DateTimeAggregate`.
- `JoinType` enum (`Inner`, `Left`, `Right`, `Full`).
