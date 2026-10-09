# Changelog

All notable changes to PureQL.CSharp.Model are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).
Versioning mirrors the PureQL specification with a `-csharp.N` suffix where needed.

---

## [Unreleased] — spec 0.1.0-preview.1.0.0

Rewrites the model for PureQL specification `0.1.0-preview.1.0.0`, which
replaces the whole expression model and enforces its type system in the
schema. Every existing query must be rebuilt with the new types. Type
names follow the schema's `$defs` keys in PascalCase, the same names as
the TypeScript model.

### Added

- **Root unions** `PureQLQuery` (`MainGroupedQuery` | `MainPlainQuery`)
  and `Query` (`GroupedQuery` | `PlainQuery`) for subqueries.
- **Subqueries** — `Subquery(name, query)`, `FromSubquery`,
  `JoinSubquery`, and `ListSubqueryColumn*` for `in` over a subquery
  column.
- **Contexts** — expression types per context in `RowExpressions`,
  `ProjectionExpressions` and `GroupExpressions`, with one value union
  per type and nullability (`IntegerRow`, `DecimalNullableGroup`, …).
- **Types** `integer` and `decimal` (replacing `number`) and nullable
  forms of every type (`TypeIntegerNullable`, …); typed null literals
  (`LiteralIntegerNullable`, …).
- **Operators** `notEqual`, `in`, `if`, `coalesce`, `concat`,
  `integerDivide`, `modulo`, `floor`, `ceiling`, `round`, and
  `dateAddDays`, `dateDiffDays`, `timeAddSeconds`, `timeDiffSeconds`,
  `datetimeAddSeconds`, `datetimeDiffSeconds` in every context.
- **Aggregates** with `Selector`, optional `Predicate` and `Over`
  (`AggregateOver`); `any` and `all`.
- **Group keys** (`GroupKey*`) over any row expression, referenced with
  `Key*(index)`; typed select columns (`SelectItemGroup*`,
  `SelectItemProjection*`); `OrderItemGroup` / `OrderItemProjection`
  over any expression.
- **Join aliases** for self-joins; **parameterized pagination**
  (`Skip` / `Take` are `OneOf<long, ParamInteger>`).
- **Lists** (`ListInteger`, …) as values for `in`.

### Removed

- The previous expression model: `Query`, `FromExpression`,
  `SelectExpression`, `OrderByItem`, `Equality` and the `Aggregates`,
  `Arithmetics`, `ArrayEqualities`, `ArrayParameters`, `ArrayReturnings`,
  `ArrayScalars`, `ArrayTypes`, `BooleanOperations`, `Comparisons`,
  `Each*`, `Equalities`, `Returnings` and `Scalars` namespaces.
- The `null` and `number` types, and per-type field / parameter names
  (`NumberField`, `StringParameter`, …) — replaced by `FieldInteger`,
  `ParamString`, ….

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