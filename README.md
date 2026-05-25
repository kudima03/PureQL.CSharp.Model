# PureQL.CSharp.Model

Typed C# AST for building PureQL queries — immutable, AOT-compatible records and discriminated unions that model every clause of a SQL-like query.

[![.NET build & test](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/PureQL.CSharp.Model)](https://www.nuget.org/packages/PureQL.CSharp.Model)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`PureQL.CSharp.Model` defines the abstract syntax tree (AST) used across the PureQL ecosystem to represent database queries in C#. Every clause of a query — fields, scalar values, named parameters, conditions, joins, aggregates, arithmetic operations, and pagination — is encoded as an immutable record or discriminated union (via [OneOf](https://github.com/mcintyre321/OneOf)). Query builders construct instances of these types; a separate translator package interprets them.

## Query Model

`Query` is the top-level sealed record that assembles all clauses:

| Property | Type | Description |
|----------|------|-------------|
| `From` | `FromExpression` | Entity name and optional alias |
| `SelectExpressions` | `IEnumerable<SelectExpression>` | Columns or array columns to return |
| `Where` | `OneOf<BooleanReturning, BooleanArrayReturning>?` | Filter predicate (scalar or per-row) |
| `Join` | `IEnumerable<Join>?` | Join clauses |
| `GroupBy` | `IEnumerable<Field>?` | Grouping fields |
| `Having` | `BooleanReturning?` | Post-aggregate filter |
| `OrderBy` | `IEnumerable<OrderByItem>?` | Sort items (field + direction) |
| `Pagination` | `Pagination?` | Skip / Take |
| `Distinct` | `bool` | Deduplicate result rows (default `false`) |

## Type Hierarchy

### Core

| Type | Kind | Description |
|------|------|-------------|
| `Query` | sealed record | Top-level query node |
| `FromExpression` | sealed record | Entity name + optional alias for FROM |
| `SelectExpression` | sealed class | `SingleValueReturning` or `ArrayReturning` with optional alias |
| `Join` | sealed record | `JoinType`, entity name, and ON condition (`BooleanReturning` or `BooleanArrayReturning`) |
| `JoinType` | enum | Left, Right, Inner, Full |
| `OrderByItem` | sealed record | `Field` reference + `SortDirection` (default `Asc`) |
| `SortDirection` | enum | Asc, Desc |
| `Equality` | sealed class | `SingleValueEquality` or `ArrayEquality` |
| `Pagination` | sealed record | Skip and Take counts |

### Fields (`PureQL.CSharp.Model.Fields`)

`IField` exposes `Entity`, `Field`, and `IType`. `Field` is a discriminated union over:
`BooleanField`, `DateField`, `DateTimeField`, `NullField`, `NumberField`, `TimeField`, `UuidField`, `StringField`.

Fields are used in GROUP BY and ORDER BY clauses. Each concrete field takes `(string entity, string field)`.

### Types (`PureQL.CSharp.Model.Types`)

`IType` (single `Name` property) with concrete records: `BooleanType`, `DateType`, `DateTimeType`, `NumberType`, `StringType`, `TimeType`, `UuidType`, `NullType`. Array counterparts live in `PureQL.CSharp.Model.ArrayTypes`.

### Scalars (`PureQL.CSharp.Model.Scalars`)

Inline literal values: `INumberScalar` / `NumberScalar`, `IBooleanScalar` / `BooleanScalar`, and equivalents for Date, DateTime, String, Time, Uuid, Null.

### Parameters (`PureQL.CSharp.Model.Parameters`)

Named placeholders (`IParameter` — `Name` + `IType`): `NumberParameter`, `BooleanParameter`, `DateParameter`, `DateTimeParameter`, `StringParameter`, `TimeParameter`, `UuidParameter`, `NullParameter`. Array variants in `PureQL.CSharp.Model.ArrayParameters`.

### Returnings (`PureQL.CSharp.Model.Returnings`)

Typed value expressions used in SELECT, WHERE, comparisons, and joins:

| Type | Variants |
|------|---------|
| `SingleValueReturning` | Boolean, Date, DateTime, Number, String, Time, Uuid returnings |
| `ArrayReturning` | Boolean, Date, DateTime, Number, String, Time, Uuid array returnings |
| `BooleanReturning` | `BooleanParameter`, `BooleanScalar`, `Equality`, `BooleanOperator`, `Comparison` |
| `NumberReturning` | `NumberParameter`, `NumberScalar`, `Arithmetic`, `NumberAggregate`, `Count` |
| `StringReturning` | `StringParameter`, `StringScalar`, `StringAggregate` |
| `DateReturning` | `DateParameter`, `DateScalar`, `DateAggregate` |
| `TimeReturning` | `TimeParameter`, `TimeScalar`, `TimeAggregate` |
| `DateTimeReturning` | `DateTimeParameter`, `DateTimeScalar`, `DateTimeAggregate` |
| `UuidReturning` | `UuidParameter`, `UuidScalar` |

### Array Returnings (`PureQL.CSharp.Model.ArrayReturnings`)

Per-row value expressions used in `Where`, `Join.On`, and per-row operations:

| Type | Variants |
|------|---------|
| `BooleanArrayReturning` | `BooleanArrayParameter`, `BooleanField`, `BooleanArrayScalar`, `EachComparison`, `EachEquality`, `EachBooleanOperator` |
| `NumberArrayReturning` | `NumberArrayParameter`, `NumberField`, `NumberArrayScalar`, `EachArithmetic`, `EachDateDiffDays`, `EachDateTimeDiffSeconds`, `EachTimeDiffSeconds` |
| `DateArrayReturning` | `DateArrayParameter`, `DateField`, `DateArrayScalar`, `EachDateAddDays` |
| `TimeArrayReturning` | `TimeArrayParameter`, `TimeField`, `TimeArrayScalar`, `EachTimeAddSeconds` |
| `DateTimeArrayReturning` | `DateTimeArrayParameter`, `DateTimeField`, `DateTimeArrayScalar`, `EachDateTimeAddSeconds` |
| `StringArrayReturning` | `StringArrayParameter`, `StringField`, `StringArrayScalar` |
| `UuidArrayReturning` | `UuidArrayParameter`, `UuidField`, `UuidArrayScalar` |

### Conditions

**Comparisons** (`PureQL.CSharp.Model.Comparisons`): `Comparison` wraps `DateComparison`, `DateTimeComparison`, `NumberComparison`, `StringComparison`, or `TimeComparison`. Each holds a `ComparisonOperator` (GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual) and typed Left / Right returnings.

**Equalities** (`PureQL.CSharp.Model.Equalities`): `SingleValueEquality` wraps Boolean, Date, DateTime, Number, String, Time, or Uuid equality types. Each holds typed Left / Right returnings.

**Boolean operations** (`PureQL.CSharp.Model.BooleanOperations`): `BooleanOperator` wraps `AndOperator`, `OrOperator`, or `NotOperator`. And/Or accept either `IEnumerable<BooleanReturning>` or a `BooleanArrayReturning`.

### Per-Row Predicates

**Each equalities** (`PureQL.CSharp.Model.EachEqualities`): `EachEquality` wraps `EachBooleanEquality`, `EachNumberEquality`, `EachStringEquality`, `EachDateEquality`, `EachTimeEquality`, `EachDateTimeEquality`, `EachUuidEquality`. Returns `BooleanArrayReturning`.

**Each comparisons** (`PureQL.CSharp.Model.EachComparisons`): `EachComparison` wraps `EachNumberComparison`, `EachStringComparison`, `EachDateComparison`, `EachTimeComparison`, `EachDateTimeComparison`. Operator values in `EachComparisonOperator`. Returns `BooleanArrayReturning`.

**Each boolean operations** (`PureQL.CSharp.Model.EachBooleanOperations`): `EachBooleanOperator` wraps `EachAndOperator`, `EachOrOperator`, `EachNotOperator` — element-wise composition over `BooleanArrayReturning` operands.

### Per-Row Arithmetic

**Each numeric arithmetic** (`PureQL.CSharp.Model.EachArithmetics`): `EachArithmetic` wraps `EachAdd`, `EachSubtract`, `EachMultiply`, `EachDivide`. Each accepts `IEnumerable<OneOf<NumberReturning, NumberArrayReturning>>` (min 2 items). Returns `NumberArrayReturning`.

**Each date arithmetic** (`PureQL.CSharp.Model.EachDateArithmetics`):
- `EachDateAddDays` — adds N days per row → `DateArrayReturning`
- `EachDateDiffDays` — date difference in days → `NumberArrayReturning`

**Each datetime arithmetic** (`PureQL.CSharp.Model.EachDateTimeArithmetics`):
- `EachDateTimeAddSeconds` — adds N seconds per row → `DateTimeArrayReturning`
- `EachDateTimeDiffSeconds` — datetime difference in seconds → `NumberArrayReturning`

**Each time arithmetic** (`PureQL.CSharp.Model.EachTimeArithmetics`):
- `EachTimeAddSeconds` — adds N seconds per row → `TimeArrayReturning`
- `EachTimeDiffSeconds` — time difference in seconds → `NumberArrayReturning`

### Aggregates (`PureQL.CSharp.Model.Aggregates`)

| Type | Variants |
|------|---------|
| `Count` | Takes any `ArrayReturning` |
| `NumberAggregate` | AverageNumber, MaxNumber, MinNumber, SumNumber |
| `DateAggregate` | AverageDate, MaxDate, MinDate |
| `DateTimeAggregate` | AverageDateTime, MaxDateTime, MinDateTime |
| `TimeAggregate` | AverageTime, MaxTime, MinTime |
| `StringAggregate` | MaxString, MinString |

### Arithmetics (`PureQL.CSharp.Model.Arithmetics`)

`Arithmetic` wraps `Add`, `Divide`, `Multiply`, `Subtract`. Each takes `IEnumerable<NumberReturning>` as arguments.

## Design Principles

- **Immutable** — all public types are sealed records or sealed classes; properties are init-only.
- **Discriminated unions** — `OneOf`-based types make exhaustive pattern matching explicit, with no unsafe casting.
- **AOT-compatible** — `IsAotCompatible = true`; safe for NativeAOT and trimming scenarios.

## Target Frameworks

- .NET 6
- .NET 7
- .NET 8
- .NET 9
- .NET 10

## Installation

```bash
dotnet add package PureQL.CSharp.Model
```

## Usage

Build a query that selects user names where age exceeds a threshold, ordered by name:

```csharp
using OneOf;
using PureQL.CSharp.Model;
using PureQL.CSharp.Model.Comparisons;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Returnings;
using PureQL.CSharp.Model.Scalars;

Query query = new Query(
    from: new FromExpression("users", "u"),
    selectExpressions: new[]
    {
        new SelectExpression(
            new SingleValueReturning(
                new StringReturning(new StringParameter("name"))),
            alias: "user_name"),
    },
    where: new OneOf<BooleanReturning, BooleanArrayReturning>?(
        new BooleanReturning(
            new Comparison(
                new NumberComparison(
                    ComparisonOperator.GreaterThan,
                    new NumberReturning(new NumberParameter("age")),
                    new NumberReturning(new NumberScalar(18)))))),
    join: null,
    groupBy: null,
    having: null,
    orderBy: new[]
    {
        new OrderByItem(new Field(new StringField("u", "name")), SortDirection.Asc),
    },
    pagination: new Pagination(skip: 0, take: 50),
    distinct: false
);
```