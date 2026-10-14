# PureQL.CSharp.Model

Typed C# AST for building PureQL queries — immutable, AOT-compatible records and discriminated unions that model every clause of a SQL-like query.

[![.NET build & test](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/PureQL.CSharp.Model)](https://www.nuget.org/packages/PureQL.CSharp.Model)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`PureQL.CSharp.Model` defines the abstract syntax tree (AST) used across the PureQL ecosystem to represent database queries in C#. It mirrors the [PureQL specification](https://github.com/kudima03/PureQL-Specification) `0.1.0-preview.2.0.1`: every operator signature of the JSON Schema has a C# record named after its `$defs` key in PascalCase (`add.integer.nullable@row` → `AddIntegerNullableRow`, `equal.string@group` → `EqualStringGroup`). Types are immutable records, and every choice is a discriminated union built on [OneOf](https://github.com/mcintyre321/OneOf). Query builders construct instances of these types; serializers and translators live in separate packages.

Because the specification enforces its type system in the schema, so does this model. Every node has an exact declared type, given by its record type, and positions accept only the declared types the schema allows. So a nullable value cannot be used as a condition, a field cannot appear in `having`, and an aggregate cannot appear in `where`: such queries do not compile.

Value rules are left to serializers: the schema holds `time` and `datetime` to microseconds and `datetime` to UTC, while `TimeOnly` and `DateTimeOffset` can carry 100-nanosecond ticks and any offset. Dates start at `0001-01-01` in both.

## Query Model

`PureQLQuery` is the root union: `MainGroupedQuery` (with `groupBy`), `MainPlainQuery` (one row per row) or `MainTotalQuery` (`aggregate` instead of `select`: exactly one row). Subqueries use the same shapes without `subqueries` (`Query` = `GroupedQuery` | `PlainQuery` | `TotalQuery`).

| Property | Type | Description |
|----------|------|-------------|
| `Subqueries` | `IEnumerable<Subquery>?` | Named subqueries, main query only |
| `From` | `From` | `FromEntity` or `FromSubquery`, with optional alias |
| `Joins` | `IEnumerable<Join>?` | `JoinEntity` or `JoinSubquery`, `JoinKind`, `On` condition, optional alias |
| `Where` | `BooleanRow?` | Row filter |
| `GroupBy` | `IEnumerable<GroupKey>` | Group keys with alias, grouped queries only |
| `Having` | `BooleanGroup?` | Group filter, grouped queries only |
| `Select` | `IEnumerable<SelectItemProjection>` / `IEnumerable<SelectItemGroup>` | Columns with alias; a column has the type its expression declares |
| `Aggregate` | `IEnumerable<SelectItemTotal>` | Columns of a total query |
| `OrderBy` | `IEnumerable<OrderItemProjection>?` / `IEnumerable<OrderItemGroup>?` | Sort expression + `SortDirection` (default `Asc`) |
| `DistinctBy` | `IEnumerable<string>?` | `select` aliases: of the rows equal on them, the first in `orderBy` order is kept |
| `Pagination` | `Pagination?` | Skip / Take, each a number or an `integer` parameter; requires `OrderBy` |

Total queries have no `OrderBy`, `DistinctBy`, `Pagination` or `Having`.

## Expressions and contexts

Each expression exists once per **context**, which fixes what it may reference:

| Context | Namespace | Used in | Leaves |
|---------|-----------|---------|--------|
| row | `RowExpressions` | `where`, `join.on`, group keys, aggregate selector / predicate | fields, parameters, literals |
| projection | `ProjectionExpressions` | `select` / `orderBy` of a plain query | fields, parameters, literals, aggregates over all rows |
| group | `GroupExpressions` | `select` / `having` / `orderBy` with `groupBy` | group keys, parameters, literals, aggregates |
| total | `TotalExpressions` | `aggregate` of a total query | parameters, literals, aggregates over all rows |

Every operator record implements `IOperator` and exposes its exact declared type as `IType Type`: `AddIntegerRow` is `integer`, `AddDecimalNullableRow` is `decimal?`, `EqualStringRow` is `boolean`. Operators whose type the schema fixes (`and`, `or`, `not`, `count`, `any`, `all`) carry no type in their name. `equal`, `notEqual`, `in` and the comparisons have one record per family of operands (`EqualDecimalRow`, …, `EqualUuidRow`) under one union (`EqualRow`).

Per context there are two kinds of value unions (types `integer`, `decimal`, `string`, `boolean`, `date`, `time`, `datetime`, `uuid`):

- **Exact unions** hold every expression that declares exactly one type: `ExactDecimalNullableRow` holds the fields, parameters and literals of type `decimal?` and every operator declaring `decimal?`.
- **Positions** (`IntegerRow`, `DecimalNullableGroup`, `BooleanNullableProjection`, …) are the operand types of the schema. Each one is a union of the exact unions whose type it accepts under the implicit conversions `T` → `T?` and `integer` → `decimal`: `DecimalNullableRow` = `ExactDecimalRow` | `ExactDecimalNullableRow` | `IntegerRow` | `ExactIntegerNullableRow`. A position that accepts only its own type is that exact union: `IntegerRow`, `StringRow`, `BooleanRow`, `DateRow`, `TimeRow`, `DatetimeRow`, `UuidRow` and their counterparts in other contexts.

Group keys and select columns take an exact union, so their `Type` is always the type their expression declares.

OneOf supports at most nine cases, so the operators of an exact union are grouped by family:

| Family | Example | Members |
|--------|---------|---------|
| `Logical{Ctx}` | `LogicalRow` | `And`, `Or`, `Not` |
| `Comparison{Ctx}` | `ComparisonRow` | `EqualRow`, `NotEqualRow`, `InRow`, `GreaterThanRow`, `LessThanRow`, `GreaterThanOrEqualRow`, `LessThanOrEqualRow`, each over every type |
| `Arithmetic{T}{Ctx}` | `ArithmeticDecimalRow` | `add`, `subtract`, `multiply`, `divide`, `integerDivide`, `modulo` |
| `Rounding{T}{Ctx}` | `RoundingIntegerRow` | `floor`, `ceiling`, `round` |
| `Difference{T}{Ctx}` | `DifferenceDecimalRow` | `dateDiffDays`, `timeDiffSeconds`, `datetimeDiffSeconds` |
| `Conditional{T}{Ctx}` | `ConditionalStringRow` | `if`, `coalesce` |
| `Aggregate{T}{Ctx}` | `AggregateIntegerGroup` | `count`, `sum`, `average`, `min`, `max`, `any`, `all` |

A family with a single member (`concat`, `dateAddDays`, `round` with `digits`, …) is a direct case of the exact union.

### Leaves

| Namespace | Records | Interface |
|-----------|---------|-----------|
| `Fields` | `FieldInteger(source, field)`, `FieldIntegerNullable`, … | `IField` |
| `Parameters` | `ParamInteger(name)`, … | `IParameter` |
| `Literals` | `LiteralInteger(long)`, `LiteralDecimal(decimal)`, `LiteralDate(DateOnly)`, `LiteralTime(TimeOnly)`, `LiteralDatetime(DateTimeOffset)`, `LiteralUuid(Guid)`, …; `LiteralIntegerNullable()` is the typed `null` | `ILiteral` |
| `Keys` | `KeyInteger(key)`, … — a reference to a group key by its alias | `IKey` |
| `Lists` | `ListInteger` = `ListLiteralInteger` \| `ListParamInteger` \| `ListSubqueryColumnInteger`; accepted only by `in` | — |
| `Types` | `TypeInteger`, `TypeIntegerNullable`, `TypeIntegerList`, … | `IType` |

Every leaf, operator, select item and group key exposes its declared type through `IType Type`.

### Aggregates

Aggregates take a row `Selector` (except `count`), an optional row `Predicate` (required for `any` / `all`) and, in grouped queries, `Over` (`AggregateOver.Group` by default, or `All`). In a plain or grouped query, `average`, `min` and `max` are non-null with a non-null selector and no predicate (`MinDecimalGroup` has no `Predicate`), and nullable otherwise. In a total query they are always nullable.

The schema also checks a few rules that the C# types do not express. Write queries so that they hold:

- An operator's declared type is exact: `AddDecimalRow` needs at least one `decimal` operand, a nullable signature needs a nullable operand, and `SumDecimal…` needs a `decimal` selector.
- `and` / `or` take at least two conditions; `coalesce` has at most one non-null operand.
- `pagination` requires `orderBy`.

## Design Principles

- **Immutable** — all public types are sealed records or sealed classes; properties are get-only.
- **Discriminated unions** — `OneOf`-based types make exhaustive pattern matching explicit, with no unsafe casting.
- **Schema parity** — operator records and positions follow the specification's `$defs` names; the TypeScript model (`@elegant-soft/pureql-typescript-model`) uses the same names.
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

Count orders per user and keep users with at least five orders (`samples/45_having.json`):

```csharp
using PureQL.CSharp.Model;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.GroupKeys;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.SelectItems;

PureQLQuery query = new PureQLQuery(
    new MainGroupedQuery(
        new From(new FromEntity("orders")),
        groupBy:
        [
            new GroupKey(
                new GroupKeyNonNullable(
                    new GroupKeyUuid(
                        "user_id",
                        new UuidRow(new FieldUuid("orders", "user_id"))
                    )
                )
            ),
        ],
        select:
        [
            new SelectItemGroup(
                new SelectItemGroupNonNullable(
                    new SelectItemGroupUuid("user_id", new UuidGroup(new KeyUuid("user_id")))
                )
            ),
            new SelectItemGroup(
                new SelectItemGroupNonNullable(
                    new SelectItemGroupInteger(
                        "orders",
                        new IntegerGroup(new AggregateIntegerGroup(new CountGroup()))
                    )
                )
            ),
        ],
        subqueries: null,
        joins: null,
        where: null,
        having: new BooleanGroup(
            new ComparisonGroup(
                new GreaterThanOrEqualGroup(
                    // count is an integer, compared through decimal
                    new GreaterThanOrEqualDecimalGroup(
                        new DecimalNullableGroup(
                            new IntegerGroup(new AggregateIntegerGroup(new CountGroup()))
                        ),
                        new DecimalNullableGroup(new IntegerGroup(new LiteralInteger(5)))
                    )
                )
            )
        ),
        orderBy: null,
        pagination: null,
        distinctBy: null
    )
);
```
