# PureQL.CSharp.Model

Typed C# AST for building PureQL queries — immutable, AOT-compatible records and C# unions that model every node of a SQL-like query.

[![.NET build & test](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/PureQL.CSharp.Model/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/PureQL.CSharp.Model)](https://www.nuget.org/packages/PureQL.CSharp.Model)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`PureQL.CSharp.Model` defines the abstract syntax tree (AST) used across the PureQL ecosystem to represent database queries in C#. It is generated from the [PureQL specification](https://github.com/kudima03/PureQL-Specification) `0.1.0-preview.2.0.1` and mirrors its nodes strictly: every node of the JSON Schema is a sealed record named after its `$defs` key in PascalCase (`add.integer.nullable@row` → `AddIntegerNullableRow`, `equal.string@group` → `EqualStringGroup`), and every choice between nodes is a C# 15 [`union`](https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/union). The names are those of the TypeScript model ([`@elegant-soft/pureql-typescript-model`](https://github.com/kudima03/PureQL.TypeScript.Model)). Query builders construct instances of these types; serializers and translators live in separate packages.

Because the specification enforces its type system in the schema, so does this model. Every node has an exact declared type, given by its record type, and positions accept only the declared types the schema allows. So a nullable value cannot be used as a condition, a field cannot appear in `having`, an aggregate cannot appear in `where`, and a paginated query cannot leave out `orderBy`: such queries do not compile.

Value rules are left to serializers: the schema holds `time` and `datetime` to microseconds and `datetime` to UTC, while `TimeOnly` and `DateTimeOffset` can carry 100-nanosecond ticks and any offset. Dates start at `0001-01-01` in both.

## Unions

Every union is flat: it lists the records it admits directly, so a node converts to every union it may stand in, and a `switch` over a union is exhaustive without a discard arm.

```csharp
DecimalNullableRow operand = new FieldInteger("orders", "quantity"); // integer → decimal?
BooleanRow condition = new GreaterThanDecimalRow(operand, new LiteralDecimal(1.5m));

string Describe(From from) => from switch
{
    FromEntity entity => entity.Entity,
    FromSubquery subquery => subquery.Subquery,
};
```

A union's `Value` is the record it holds. Optional properties are nullable (`BooleanRow? Where`), absent enum properties are their first member (`SortDirection.Asc`, `AggregateOver.Group`).

## Query Model

`PureQLQuery` is the root union. A query is grouped (with `groupBy`), total (`aggregate` instead of `select`: exactly one row) or plain (one row per row), and the schema's dependencies between clauses split each kind into variants:

| Union | Variants |
|-------|----------|
| `PureQLQuery` | `MainGroupedQueryWithoutPagination`, `MainGroupedQueryWithPagination`, `MainTotalQuery`, `MainPlainQueryWithoutPagination`, `MainPlainQueryWithPagination` |
| `Query` (subqueries) | `GroupedQueryWithoutPaginationWithoutOrderBy`, `GroupedQueryWithoutPaginationWithOrderBy`, `GroupedQueryWithPagination`, `TotalQuery`, `PlainQueryWithoutPaginationWithoutOrderBy`, `PlainQueryWithoutPaginationWithOrderBy`, `PlainQueryWithPagination` |

`pagination` requires `orderBy`, so a `…WithPagination` query has a required `OrderBy`; in a subquery `orderBy` also requires `pagination` or `distinctBy`, so `…WithoutPaginationWithOrderBy` has a required `DistinctBy`. Subqueries have no `Subqueries`.

| Property | Type | Description |
|----------|------|-------------|
| `Subqueries` | `IEnumerable<Subquery>?` | Named subqueries, main query only |
| `From` | `From` | `FromEntity` or `FromSubquery`, with optional alias |
| `Joins` | `IEnumerable<Join>?` | `JoinEntity` or `JoinSubquery`, `JoinKind`, `On` condition, optional alias |
| `Where` | `BooleanRow?` | Row filter |
| `GroupBy` | `IEnumerable<GroupKey>` | Group keys: alias and row expression, grouped queries only |
| `Having` | `BooleanGroup?` | Group filter, grouped queries only |
| `Select` | `IEnumerable<SelectItemProjection>` / `IEnumerable<SelectItemGroup>` | Columns: alias and expression; a column has the type its expression declares |
| `Aggregate` | `IEnumerable<SelectItemTotal>` | Columns of a total query |
| `OrderBy` | `IEnumerable<OrderItemProjection>` / `IEnumerable<OrderItemGroup>` | Sort expression + `SortDirection` (default `Asc`) |
| `DistinctBy` | `IEnumerable<string>` | `select` aliases: of the rows equal on them, the first in `orderBy` order is kept |
| `Pagination` | `Pagination` | `Skip` / `Take`, each a number or an `integer` parameter (`PaginationSkip` = `long` \| `ParamInteger`) |

Total queries have no `OrderBy`, `DistinctBy`, `Pagination` or `Having`.

## Expressions and contexts

Each expression exists once per **context**, which fixes what it may reference:

| Context | Namespace | Used in | Leaves |
|---------|-----------|---------|--------|
| row | `RowExpressions` | `where`, `join.on`, group keys, aggregate selector / predicate | fields, parameters, literals |
| projection | `ProjectionExpressions` | `select` / `orderBy` of a plain query | fields, parameters, literals, aggregates over all rows |
| group | `GroupExpressions` | `select` / `having` / `orderBy` with `groupBy` | group keys, parameters, literals, aggregates |
| total | `TotalExpressions` | `aggregate` of a total query | parameters, literals, aggregates over all rows |

Every operator record implements `IOperator` and exposes its exact declared type as `IType Type`: `AddIntegerRow` is `integer`, `AddDecimalNullableRow` is `decimal?`, `EqualStringRow` is `boolean`. Operators whose type the schema fixes (`and`, `or`, `not`, `count`, `any`, `all`) carry no type in their name. `equal`, `notEqual`, `in` and the comparisons have one record per family of operands (`EqualDecimalRow`, …, `EqualUuidRow`).

Per context, the expression unions are (types `integer`, `decimal`, `string`, `boolean`, `date`, `time`, `datetime`, `uuid`):

- **Positions** (`IntegerRow`, `DecimalNullableGroup`, `BooleanNullableProjection`, …), the operand types of the schema. Each one holds every expression whose declared type it accepts under the implicit conversions `T` → `T?` and `integer` → `decimal`: `DecimalNullableRow` holds the expressions declaring `integer`, `integer?`, `decimal` and `decimal?`.
- **`Expr{Ctx}`** (`ExprRow`, …), every expression of the context: group keys, select columns and `orderBy` items take it, so their type is the type their expression declares.
- **Narrower operands** where the schema asks for them: `DeclaresDecimalRow` (exactly `decimal`: the selector of `MaxDecimalGroup`), `DeclaresStringNullableRow` (the operands of `CoalesceStringNullableRow`), `DecimalOrDecimalNullableRow` (the selector of `SumDecimalTotal`), `IntegerNullableOrDecimalNullableRow` (the operand of `RoundIntegerNullableRow`).

### Leaves

| Namespace | Records | Interface |
|-----------|---------|-----------|
| `Fields` | `FieldInteger(source, field)`, `FieldIntegerNullable`, … | `IField` |
| `Parameters` | `ParamInteger(param)`, … | `IParameter` |
| `Literals` | `LiteralInteger(long)`, `LiteralDecimal(decimal)`, `LiteralDate(DateOnly)`, `LiteralTime(TimeOnly)`, `LiteralDatetime(DateTimeOffset)`, `LiteralUuid(Guid)`, …; `LiteralIntegerNullable()` is the typed `null` | `ILiteral` |
| `Keys` | `KeyInteger(key)`, … — a reference to a group key by its alias | `IKey` |
| `Lists` | `ListDecimal` = `ListLiteralDecimal` \| `ListParamDecimal` \| `ListSubqueryColumnDecimal` \| `ListSubqueryColumnDecimalNullable` \| the integer lists; accepted only by `in` | `ILiteral`, `IParameter`, `ISubqueryColumn` |
| `Types` | `TypeInteger`, `TypeIntegerNullable`, `TypeIntegerList`, … | `IType` |

### Aggregates

Aggregates take a row `Selector` (except `count`), an optional row `Predicate` (required for `any` / `all`) and, in grouped queries, `Over` (`AggregateOver.Group` by default, or `All`). In a plain or grouped query, `average`, `min` and `max` are non-null with a non-null selector and no predicate (`MinDecimalGroup` has no `Predicate`), and nullable otherwise. In a total query they are always nullable.

The schema also checks a few rules that the C# types do not express. Write queries so that they hold:

- An operator with several operands declares its type exactly: `AddDecimalRow` needs at least one `decimal` operand, and a nullable signature needs a nullable operand.
- `and` / `or` take at least two conditions; `coalesce` has at most one non-null operand; arrays such as `values`, `joins` or `select` are not empty.

## Design Principles

- **Generated** — the model is generated from the pinned specification by `PureQL.CSharp.Model.Generator`; nothing in it is written by hand.
- **Immutable** — all public types are sealed records or read-only unions; properties are get-only.
- **Unions** — C# 15 unions make exhaustive pattern matching explicit, with no unsafe casting.
- **Schema parity** — records and unions follow the specification's `$defs` names; the TypeScript model uses the same names.
- **AOT-compatible** — `IsAotCompatible = true`; safe for NativeAOT and trimming scenarios.

## Target Frameworks

- .NET 11

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
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;

PureQLQuery query = new MainGroupedQueryWithoutPagination(
    new FromEntity("orders"),
    groupBy: [new GroupKey("user_id", new FieldUuid("orders", "user_id"))],
    select:
    [
        new SelectItemGroup("user_id", new KeyUuid("user_id")),
        new SelectItemGroup("orders", new CountGroup()),
    ],
    // count is an integer, compared through decimal
    having: new GreaterThanOrEqualDecimalGroup(new CountGroup(), new LiteralInteger(5))
);
```

## Generating the model

From `./src`:

```bash
dotnet run --project PureQL.CSharp.Model.Generator
```

The generator fetches the specification at the tag it pins (`Program.SchemaTag`), normalizes it with a port of the TypeScript model's normalizer, and rewrites every `.cs` file of `PureQL.CSharp.Model`. Pass `--schema <PureQL-Specification.json>` to generate from a local file. CI fails if the committed model differs from the generated one.
