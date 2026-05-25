# Changelog

All notable changes to PureQL.CSharp.Model are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).
Versioning mirrors the PureQL specification with a `-csharp.N` suffix where needed.

---

## [0.1.0-preview.11.0.0] — spec 0.1.0-preview.0.5.0

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
- **`NullField`** added and included as the 8th variant in the `Field` union,
  matching the `nullField` entry in the spec's `field` definition.
- **`FromExpression.Alias`** is now optional (`string?` with default `null`),
  matching the spec where `alias` is not in the `required` array.
- **`Query.Distinct`** property added (`bool`, default `false`), matching the
  `distinct` property defined at the root query level in the spec.