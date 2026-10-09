# PureQL.CSharp.Model

Typed C# AST for building PureQL queries — immutable, AOT-compatible records and discriminated unions that model every clause of a SQL-like query.

[![.NET build & test](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/PureQL.CSharp.Model)](https://www.nuget.org/packages/PureQL.CSharp.Model)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`PureQL.CSharp.Model` defines the abstract syntax tree (AST) used across the PureQL ecosystem to represent database queries in C#. It mirrors the [PureQL specification](https://github.com/kudima03/PureQL-Specification) `0.1.0-preview.1.0.0` one-to-one: every `$defs` entry of the JSON Schema has a C# type with the same name in PascalCase (`add.integer@row` → `AddIntegerRow`, `selectItem@group` → `SelectItemGroup`). Types are immutable records, and every choice is a discriminated union built on [OneOf](https://github.com/mcintyre321/OneOf). Query builders construct instances of these types; serializers and translators live in separate packages.

Because the specification enforces its type system in the schema, so does this model: a column declares its type, a nullable value cannot be used as a condition, a field cannot appear in `having`, and an aggregate cannot appear in `where` — such queries do not compile.

## Query Model

`PureQLQuery` is the root union: `MainGroupedQuery` (with `groupBy`) or `MainPlainQuery`. Subqueries use the same shapes without `subqueries` (`Query` = `GroupedQuery` | `PlainQuery`).

| Property | Type | Description |
|----------|------|-------------|
| `Subqueries` | `IEnumerable<Subquery>?` | Named subqueries, main query only |
| `From` | `From` | `FromEntity` or `FromSubquery`, with optional alias |
| `Joins` | `IEnumerable<Join>?` | `JoinEntity` or `JoinSubquery`, `JoinType`, `On` condition, optional alias |
| `Where` | `BooleanRow?` | Row filter |
| `GroupBy` | `IEnumerable<GroupKey>` | Typed group keys, grouped queries only |
| `Having` | `BooleanGroup?` | Group filter, grouped queries only |
| `Select` | `IEnumerable<SelectItemProjection>` / `IEnumerable<SelectItemGroup>` | Columns with alias and declared type |
| `OrderBy` | `IEnumerable<OrderItemProjection>?` / `IEnumerable<OrderItemGroup>?` | Sort expression + `SortDirection` (default `Asc`) |
| `Pagination` | `Pagination?` | Skip / Take, each a number or an `integer` parameter |
| `Distinct` | `bool` | Deduplicate result rows (default `false`) |

## Expressions and contexts

Each expression exists once per **context**, which fixes what it may reference:

| Context | Namespace | Used in | Leaves |
|---------|-----------|---------|--------|
| row | `RowExpressions` | `where`, `join.on`, group keys, aggregate selector / predicate | fields, parameters, literals |
| projection | `ProjectionExpressions` | `select` / `orderBy` without `groupBy` | fields, parameters, literals, aggregates over all rows |
| group | `GroupExpressions` | `select` / `having` / `orderBy` with `groupBy` | group keys, parameters, literals, aggregates |

Per context there is one union for every value type and its nullable form: `IntegerRow`, `IntegerNullableRow`, `DecimalGroup`, `BooleanNullableProjection`, … (types `integer`, `decimal`, `string`, `boolean`, `date`, `time`, `datetime`, `uuid`). The implicit conversions of the specification (`T` → `T?`, `integer` → `decimal`) are part of these unions, exactly as in the schema.

OneOf supports at most nine cases, so the cases of a value union are grouped by operator family:

| Family | Example | Members |
|--------|---------|---------|
| leaves | `FieldAsDecimalNullable`, `ParamAs…`, `LiteralAs…`, `KeyAs…` | the field / parameter / literal / key records accepted by the value type |
| `Logical{Ctx}` | `LogicalRow` | `And`, `Or`, `Not` |
| `Comparison{Ctx}` | `ComparisonRow` | `EqualRow`, `NotEqualRow`, `InRow`, `GreaterThanRow`, `LessThanRow`, `GreaterThanOrEqualRow`, `LessThanOrEqualRow`, each over the comparable types |
| `Arithmetic…` | `ArithmeticDecimalRow` | `add`, `subtract`, `multiply`, `divide`, `integerDivide`, `modulo` |
| `Rounding…` | `RoundingDecimalRow` | `floor`, `ceiling`, `round` |
| `Difference…` | `DifferenceDecimalRow` | `dateDiffDays`, `timeDiffSeconds`, `datetimeDiffSeconds` |
| `Conditional…` | `ConditionalStringRow` | `if`, `coalesce` |
| `Aggregate…` | `AggregateIntegerGroup` | `count`, `sum`, `average`, `min`, `max`, `any`, `all` |

A family with a single member (`concat`, `dateAddDays`, …) is a direct case of the value union.

### Leaves

| Namespace | Records | Interface |
|-----------|---------|-----------|
| `Fields` | `FieldInteger(source, field)`, `FieldIntegerNullable`, … | `IField` |
| `Parameters` | `ParamInteger(name)`, … | `IParameter` |
| `Literals` | `LiteralInteger(long)`, `LiteralDecimal(decimal)`, `LiteralDate(DateOnly)`, `LiteralTime(TimeOnly)`, `LiteralDatetime(DateTimeOffset)`, `LiteralUuid(Guid)`, …; `LiteralIntegerNullable()` is the typed `null` | `ILiteral` |
| `Keys` | `KeyInteger(index)`, … — a reference to a group key | `IKey` |
| `Lists` | `ListInteger` = `ListLiteralInteger` \| `ListParamInteger` \| `ListSubqueryColumnInteger`; accepted only by `in` | — |
| `Types` | `TypeInteger`, `TypeIntegerNullable`, `TypeIntegerList`, … | `IType` |

Every leaf, select item and group key exposes its declared type through `IType Type`.

### Aggregates

Aggregates take a row `Selector` (except `count`), an optional row `Predicate` (required for `any` / `all`) and, in grouped queries, `Over` (`AggregateOver.Group` by default, or `All`). Where the schema allows only one value for `over`, the property is omitted.

## Design Principles

- **Immutable** — all public types are sealed records or sealed classes; properties are get-only.
- **Discriminated unions** — `OneOf`-based types make exhaustive pattern matching explicit, with no unsafe casting.
- **Schema parity** — names and shapes follow the specification's `$defs`; the TypeScript model (`@elegant-soft/pureql-typescript-model`) uses the same names.
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

Count orders per user and keep users with at least five orders (`samples/44_having.json`):

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
                    new GroupKeyUuid(new UuidRow(new FieldUuid("orders", "user_id")))
                )
            ),
        ],
        select:
        [
            new SelectItemGroup(
                new SelectItemGroupNonNullable(
                    new SelectItemGroupUuid("user_id", new UuidGroup(new KeyUuid(0)))
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
                    new GreaterThanOrEqualDecimalGroup(
                        new DecimalNullableGroup(
                            new AggregateDecimalNullableGroup(new CountGroup())
                        ),
                        new DecimalNullableGroup(
                            new LiteralAsDecimalNullable(new LiteralInteger(5))
                        )
                    )
                )
            )
        ),
        orderBy: null,
        pagination: null,
        distinct: false
    )
);
```
