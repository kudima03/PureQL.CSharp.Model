# PureQL.CSharp.Model

C# model library for [PureQL](https://github.com/kudima03/PureQL-Specification) — a JSON-based query language. Provides strongly-typed .NET record and discriminated-union types that mirror the PureQL JSON Schema, enabling construction, inspection, and serialisation of PureQL queries in C#.

**Current specification version:** `0.1.0-preview.0.5.0`

---

## Installation

```
dotnet add package PureQL.CSharp.Model
```

Targets: .NET 6, 7, 8, 9, 10.

---

## Core concepts

A `Query` carries:

| Property | Type | Required |
|---|---|---|
| `From` | `FromExpression` | yes |
| `SelectExpressions` | `IEnumerable<SelectExpression>` | yes |
| `Where` | `OneOf<BooleanReturning, BooleanArrayReturning>?` | no |
| `Join` | `IEnumerable<Join>?` | no |
| `GroupBy` | `IEnumerable<Field>?` | no |
| `Having` | `BooleanReturning?` | no |
| `OrderBy` | `IEnumerable<OrderByItem>?` | no |
| `Pagination` | `Pagination?` | no |

### Discriminated unions via OneOf

All polymorphic positions use `OneOf` / `OneOfBase<…>` from the [OneOf](https://github.com/mcintyre321/OneOf) package. For example `BooleanReturning` is a union of `BooleanScalar | BooleanParameter | Equality | BooleanOperator | Comparison`.

---

## Type system

### Scalar types

| C# class | JSON name |
|---|---|
| `StringScalar` | `string` |
| `NumberScalar` | `number` |
| `BooleanScalar` | `boolean` |
| `DateScalar` | `date` |
| `TimeScalar` | `time` |
| `DateTimeScalar` | `datetime` |
| `UuidScalar` | `uuid` |
| `NullScalar` | `null` |

### Field references

Each typed field (`StringField`, `NumberField`, `DateField`, …) holds `Entity` and `Field` strings. The `Field` union wraps all typed fields.

### Parameters

Named parameters (`StringParameter`, `NumberParameter`, …) identify runtime-provided values by `ParamName`.

### Array variants

Array versions of scalars, fields, and parameters exist in `ArrayScalars`, `Fields`, and `ArrayParameters` namespaces respectively.

---

## Operators

### Single-value boolean family

| Operator | C# type |
|---|---|
| `and` / `or` / `not` | `AndOperator`, `OrOperator`, `NotOperator` |
| `equal` (single-value) | `SingleValueEquality` → typed equalities |
| `equal` (array) | `ArrayEquality` → typed array equalities |
| `greaterThan` / `lessThan` / … | `Comparison` → typed comparisons |

### Per-row predicate family (`each*`)

Per-row operators return `BooleanArrayReturning` — a per-row boolean column.

| Operator | C# type |
|---|---|
| `eachEqual` | `EachEquality` (7 typed variants) |
| `eachGreaterThan` / `eachLessThan` / … | `EachComparison` (5 typed variants) |
| `eachAnd` / `eachOr` / `eachNot` | `EachAndOperator`, `EachOrOperator`, `EachNotOperator` |

### Single-value arithmetic

| Operator | C# type |
|---|---|
| `add` / `subtract` / `multiply` / `divide` | `Arithmetic` → `Add`, `Subtract`, `Multiply`, `Divide` |

### Per-row arithmetic (`each*`)

Per-row arithmetic operators accept mixed `numericReturning | numericArrayReturning` operands and return `NumberArrayReturning`.

| Operator | C# type |
|---|---|
| `eachAdd` / `eachSubtract` / `eachMultiply` / `eachDivide` | `EachArithmetic` → `EachAdd`, `EachSubtract`, `EachMultiply`, `EachDivide` |

### Per-row date / time / datetime math

| Operator | Return type | C# type |
|---|---|---|
| `eachDateAddDays` | `DateArrayReturning` | `EachDateAddDays` |
| `eachDateDiffDays` | `NumberArrayReturning` | `EachDateDiffDays` |
| `eachDatetimeAddSeconds` | `DateTimeArrayReturning` | `EachDateTimeAddSeconds` |
| `eachDatetimeDiffSeconds` | `NumberArrayReturning` | `EachDateTimeDiffSeconds` |
| `eachTimeAddSeconds` | `TimeArrayReturning` | `EachTimeAddSeconds` |
| `eachTimeDiffSeconds` | `NumberArrayReturning` | `EachTimeDiffSeconds` |

### Aggregates

| Operator | C# type |
|---|---|
| `count` | `Count` |
| `sum` / `average_number` / `min_number` / `max_number` | `NumberAggregate` |
| `min_string` / `max_string` | `StringAggregate` |
| `min_date` / `max_date` / `average_date` | `DateAggregate` |
| `min_time` / `max_time` / `average_time` | `TimeAggregate` |
| `min_datetime` / `max_datetime` / `average_datetime` | `DateTimeAggregate` |

---

## OrderBy with direction

`OrderByItem` wraps a field reference and an optional sort direction:

```csharp
var orderBy = new[]
{
    new OrderByItem(new Field(new NumberField("orders", "amount")), SortDirection.Desc),
    new OrderByItem(new Field(new StringField("orders", "name"))),  // defaults to Asc
};
```

`SortDirection` is an enum with values `Asc` and `Desc`.

---

## Usage example

```csharp
// SELECT u.id, COUNT(o.id) AS order_count
// FROM users AS u
// INNER JOIN orders AS o ON u.id = o.user_id
// WHERE u.status = 'active'
// GROUP BY u.id
// ORDER BY order_count DESC
// LIMIT 20 OFFSET 0

var usersFrom = new FromExpression("users", "u");

var userIdField = new NumberField("users", "id");
var orderIdField = new NumberField("orders", "id");
var userStatusField = new StringField("users", "status");
var orderUserIdField = new NumberField("orders", "user_id");

var select = new[]
{
    new SelectExpression(new ArrayReturning(new NumberArrayReturning(userIdField))),
    new SelectExpression(
        new SingleValueReturning(
            new NumberReturning(
                new Count(new ArrayReturning(new NumberArrayReturning(orderIdField)))
            )
        ),
        "order_count"
    ),
};

var join = new Join(
    JoinType.Inner,
    "orders",
    new BooleanArrayReturning(
        new EachEquality(
            new EachNumberEquality(
                new NumberArrayReturning(userIdField),
                OneOf<NumberReturning, NumberArrayReturning>.FromT1(
                    new NumberArrayReturning(orderUserIdField)
                )
            )
        )
    )
);

var where = OneOf<BooleanReturning, BooleanArrayReturning>.FromT1(
    new BooleanArrayReturning(
        new EachEquality(
            new EachStringEquality(
                new StringArrayReturning(userStatusField),
                OneOf<StringReturning, StringArrayReturning>.FromT0(
                    new StringReturning(new StringScalar("active"))
                )
            )
        )
    )
);

var query = new Query(
    from: usersFrom,
    selectExpressions: select,
    where: where,
    join: new[] { join },
    groupBy: new[] { new Field(userIdField) },
    having: null,
    orderBy: new[] { new OrderByItem(new Field(new NumberField("orders", "order_count")), SortDirection.Desc) },
    pagination: new Pagination(0, 20)
);
```

---

## License

[MIT](LICENSE)
