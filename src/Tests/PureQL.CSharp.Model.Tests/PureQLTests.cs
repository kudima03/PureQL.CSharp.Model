using OneOf;
using PureQL.CSharp.Model.Aggregates;
using PureQL.CSharp.Model.Aggregates.Numeric;
using PureQL.CSharp.Model.Arithmetics;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.EachArithmetics;
using PureQL.CSharp.Model.EachBooleanOperations;
using PureQL.CSharp.Model.EachComparisons;
using PureQL.CSharp.Model.EachDateArithmetics;
using PureQL.CSharp.Model.EachDateTimeArithmetics;
using PureQL.CSharp.Model.EachEqualities;
using PureQL.CSharp.Model.EachTimeArithmetics;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Returnings;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Tests;

public sealed class PureQLTests
{
    // ── helpers ──────────────────────────────────────────────────────────────

    private static NumberField NumF(string entity, string field) => new(entity, field);
    private static StringField StrF(string entity, string field) => new(entity, field);
    private static DateField DateF(string entity, string field) => new(entity, field);
    private static DateTimeField DtF(string entity, string field) => new(entity, field);
    private static TimeField TimeF(string entity, string field) => new(entity, field);
    private static UuidField UuidF(string entity, string field) => new(entity, field);
    private static BooleanField BoolF(string entity, string field) => new(entity, field);

    // ── basic query construction ──────────────────────────────────────────────

    [Fact]
    public void SimpleSelect_Constructs()
    {
        var from = new FromExpression("orders", "o");
        var select = new[]
        {
            new SelectExpression(
                new SingleValueReturning(
                    new NumberReturning(new NumberScalar(1))
                ),
                "one"
            ),
        };

        var query = new Query(from, select);

        Assert.Equal("orders", query.From.Entity);
        Assert.Single(query.SelectExpressions);
    }

    [Fact]
    public void Query_WithPagination_Constructs()
    {
        var from = new FromExpression("users", "u");
        var select = new[] { new SelectExpression(new ArrayReturning(new NumberArrayReturning(NumF("users", "id")))) };
        var pagination = new Pagination(0, 10);

        var query = new Query(from, select, null, null, null, null, null, pagination);

        Assert.NotNull(query.Pagination);
        Assert.Equal(0, query.Pagination!.Skip);
        Assert.Equal(10, query.Pagination!.Take);
    }

    // ── OrderBy with direction ────────────────────────────────────────────────

    [Fact]
    public void OrderByItem_DefaultsToAsc()
    {
        var item = new OrderByItem(new Field(NumF("orders", "amount")));

        Assert.Equal(SortDirection.Asc, item.Direction);
    }

    [Fact]
    public void OrderByItem_ExplicitDesc()
    {
        var item = new OrderByItem(new Field(NumF("orders", "amount")), SortDirection.Desc);

        Assert.Equal(SortDirection.Desc, item.Direction);
    }

    [Fact]
    public void Query_WithOrderByItem_Constructs()
    {
        var from = new FromExpression("orders", "o");
        var select = new[] { new SelectExpression(new ArrayReturning(new NumberArrayReturning(NumF("orders", "amount")))) };
        var orderBy = new[]
        {
            new OrderByItem(new Field(NumF("orders", "amount")), SortDirection.Desc),
        };

        var query = new Query(from, select, null, null, null, null, orderBy, null);

        Assert.Single(query.OrderBy!);
        Assert.Equal(SortDirection.Desc, query.OrderBy!.First().Direction);
    }

    // ── each* equality ────────────────────────────────────────────────────────

    [Fact]
    public void EachNumberEquality_WithScalarRight_Constructs()
    {
        var left = new NumberArrayReturning(NumF("orders", "status_code"));
        var right = OneOf<NumberReturning, NumberArrayReturning>.FromT0(
            new NumberReturning(new NumberScalar(200))
        );

        var equality = new EachNumberEquality(left, right);
        var boolArray = new BooleanArrayReturning(new EachEquality(equality));

        Assert.True(boolArray.IsT4);
    }

    [Fact]
    public void EachStringEquality_WithScalarRight_Constructs()
    {
        var left = new StringArrayReturning(StrF("users", "status"));
        var right = OneOf<StringReturning, StringArrayReturning>.FromT0(
            new StringReturning(new StringScalar("active"))
        );

        var equality = new EachStringEquality(left, right);
        var boolArray = new BooleanArrayReturning(new EachEquality(equality));

        Assert.True(boolArray.IsT4);
    }

    [Fact]
    public void EachUuidEquality_FieldToField_Constructs()
    {
        var left = new UuidArrayReturning(UuidF("users", "id"));
        var right = OneOf<UuidReturning, UuidArrayReturning>.FromT1(
            new UuidArrayReturning(UuidF("orders", "user_id"))
        );

        var equality = new EachUuidEquality(left, right);

        Assert.NotNull(equality);
    }

    [Fact]
    public void EachDateEquality_Constructs()
    {
        var left = new DateArrayReturning(DateF("orders", "order_date"));
        var right = OneOf<DateReturning, DateArrayReturning>.FromT0(
            new DateReturning(new DateScalar(new DateOnly(2024, 1, 1)))
        );

        var equality = new EachDateEquality(left, right);

        Assert.NotNull(equality);
    }

    [Fact]
    public void EachBooleanEquality_Constructs()
    {
        var left = new BooleanArrayReturning(BoolF("users", "is_active"));
        var right = OneOf<BooleanReturning, BooleanArrayReturning>.FromT0(
            new BooleanReturning(new BooleanScalar(true))
        );

        var equality = new EachBooleanEquality(left, right);

        Assert.NotNull(equality);
    }

    [Fact]
    public void EachTimeEquality_Constructs()
    {
        var left = new TimeArrayReturning(TimeF("shifts", "start_time"));
        var right = OneOf<TimeReturning, TimeArrayReturning>.FromT0(
            new TimeReturning(new TimeScalar(new TimeOnly(8, 0, 0)))
        );

        var equality = new EachTimeEquality(left, right);

        Assert.NotNull(equality);
    }

    [Fact]
    public void EachDateTimeEquality_Constructs()
    {
        var left = new DateTimeArrayReturning(DtF("events", "starts_at"));
        var right = OneOf<DateTimeReturning, DateTimeArrayReturning>.FromT0(
            new DateTimeReturning(new DateTimeScalar(new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)))
        );

        var equality = new EachDateTimeEquality(left, right);

        Assert.NotNull(equality);
    }

    // ── each* comparisons ─────────────────────────────────────────────────────

    [Fact]
    public void EachNumberComparison_GreaterThan_Constructs()
    {
        var left = new NumberArrayReturning(NumF("order_items", "unit_price"));
        var right = OneOf<NumberReturning, NumberArrayReturning>.FromT0(
            new NumberReturning(new NumberScalar(100))
        );

        var comparison = new EachNumberComparison(EachComparisonOperator.EachGreaterThan, left, right);
        var boolArray = new BooleanArrayReturning(new EachComparison(comparison));

        Assert.True(boolArray.IsT3);
    }

    [Fact]
    public void EachDateComparison_FieldToField_Constructs()
    {
        var left = new DateArrayReturning(DateF("orders", "shipped_at"));
        var right = OneOf<DateReturning, DateArrayReturning>.FromT1(
            new DateArrayReturning(DateF("orders", "expected_at"))
        );

        var comparison = new EachDateComparison(EachComparisonOperator.EachLessThan, left, right);

        Assert.Equal(EachComparisonOperator.EachLessThan, comparison.Operator);
    }

    [Fact]
    public void EachStringComparison_Constructs()
    {
        var left = new StringArrayReturning(StrF("products", "name"));
        var right = OneOf<StringReturning, StringArrayReturning>.FromT0(
            new StringReturning(new StringScalar("M"))
        );

        var comparison = new EachStringComparison(EachComparisonOperator.EachGreaterThanOrEqual, left, right);

        Assert.NotNull(comparison);
    }

    [Fact]
    public void EachTimeComparison_Constructs()
    {
        var left = new TimeArrayReturning(TimeF("shifts", "clock_out"));
        var right = OneOf<TimeReturning, TimeArrayReturning>.FromT0(
            new TimeReturning(new TimeScalar(new TimeOnly(17, 0, 0)))
        );

        var comparison = new EachTimeComparison(EachComparisonOperator.EachGreaterThan, left, right);

        Assert.NotNull(comparison);
    }

    [Fact]
    public void EachDateTimeComparison_Constructs()
    {
        var left = new DateTimeArrayReturning(DtF("orders", "shipped_at"));
        var right = OneOf<DateTimeReturning, DateTimeArrayReturning>.FromT0(
            new DateTimeReturning(new DateTimeScalar(new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)))
        );

        var comparison = new EachDateTimeComparison(EachComparisonOperator.EachGreaterThan, left, right);

        Assert.NotNull(comparison);
    }

    // ── each* boolean operations ──────────────────────────────────────────────

    [Fact]
    public void EachAndOperator_ComposesMultiplePredicates()
    {
        var pred1 = new BooleanArrayReturning(
            new EachEquality(
                new EachStringEquality(
                    new StringArrayReturning(StrF("users", "status")),
                    OneOf<StringReturning, StringArrayReturning>.FromT0(
                        new StringReturning(new StringScalar("active"))
                    )
                )
            )
        );

        var pred2 = new BooleanArrayReturning(
            new EachComparison(
                new EachNumberComparison(
                    EachComparisonOperator.EachGreaterThan,
                    new NumberArrayReturning(NumF("users", "score")),
                    OneOf<NumberReturning, NumberArrayReturning>.FromT0(
                        new NumberReturning(new NumberScalar(50))
                    )
                )
            )
        );

        var andOp = new EachAndOperator(new[] { pred1, pred2 });
        var result = new BooleanArrayReturning(andOp);

        Assert.True(result.IsT5);
    }

    [Fact]
    public void EachOrOperator_Constructs()
    {
        var pred1 = new BooleanArrayReturning(BoolF("users", "is_premium"));
        var pred2 = new BooleanArrayReturning(BoolF("users", "is_admin"));

        var orOp = new EachOrOperator(new[] { pred1, pred2 });
        var result = new BooleanArrayReturning(orOp);

        Assert.True(result.IsT6);
    }

    [Fact]
    public void EachNotOperator_Constructs()
    {
        var inner = new BooleanArrayReturning(
            new EachEquality(
                new EachBooleanEquality(
                    new BooleanArrayReturning(BoolF("users", "is_deleted")),
                    OneOf<BooleanReturning, BooleanArrayReturning>.FromT0(
                        new BooleanReturning(new BooleanScalar(true))
                    )
                )
            )
        );

        var notOp = new EachNotOperator(inner);
        var result = new BooleanArrayReturning(notOp);

        Assert.True(result.IsT7);
    }

    // ── per-row arithmetic ────────────────────────────────────────────────────

    [Fact]
    public void EachMultiply_FieldByScalar_ProducesNumericArrayReturning()
    {
        var fieldArg = OneOf<NumberReturning, NumberArrayReturning>.FromT1(
            new NumberArrayReturning(NumF("order_items", "unit_price"))
        );
        var scalarArg = OneOf<NumberReturning, NumberArrayReturning>.FromT0(
            new NumberReturning(new NumberScalar(1.05))
        );

        var multiply = new EachMultiply(new[] { fieldArg, scalarArg });
        var result = new NumberArrayReturning(new EachArithmetic(multiply));

        Assert.True(result.IsT3);
    }

    [Fact]
    public void EachAdd_ThreeOperands_Constructs()
    {
        var a = OneOf<NumberReturning, NumberArrayReturning>.FromT1(new NumberArrayReturning(NumF("items", "base_price")));
        var b = OneOf<NumberReturning, NumberArrayReturning>.FromT1(new NumberArrayReturning(NumF("items", "tax")));
        var c = OneOf<NumberReturning, NumberArrayReturning>.FromT1(new NumberArrayReturning(NumF("items", "shipping")));

        var add = new EachAdd(new[] { a, b, c });

        Assert.Equal(3, add.Values.Count());
    }

    [Fact]
    public void EachSubtract_Constructs()
    {
        var a = OneOf<NumberReturning, NumberArrayReturning>.FromT1(new NumberArrayReturning(NumF("items", "price")));
        var b = OneOf<NumberReturning, NumberArrayReturning>.FromT1(new NumberArrayReturning(NumF("items", "discount")));

        var subtract = new EachSubtract(new[] { a, b });
        var result = new NumberArrayReturning(new EachArithmetic(subtract));

        Assert.True(result.IsT3);
    }

    [Fact]
    public void EachDivide_Constructs()
    {
        var a = OneOf<NumberReturning, NumberArrayReturning>.FromT1(new NumberArrayReturning(NumF("items", "total")));
        var b = OneOf<NumberReturning, NumberArrayReturning>.FromT0(new NumberReturning(new NumberScalar(100)));

        var divide = new EachDivide(new[] { a, b });

        Assert.NotNull(divide.Values);
    }

    // ── per-row date math ─────────────────────────────────────────────────────

    [Fact]
    public void EachDateAddDays_ProducesDateArrayReturning()
    {
        var left = OneOf<DateReturning, DateArrayReturning>.FromT1(
            new DateArrayReturning(DateF("orders", "order_date"))
        );
        var right = OneOf<NumberReturning, NumberArrayReturning>.FromT0(
            new NumberReturning(new NumberScalar(30))
        );

        var addDays = new EachDateAddDays(left, right);
        var result = new DateArrayReturning(addDays);

        Assert.True(result.IsT3);
    }

    [Fact]
    public void EachDateDiffDays_ProducesNumericArrayReturning()
    {
        var left = OneOf<DateReturning, DateArrayReturning>.FromT1(
            new DateArrayReturning(DateF("orders", "delivered_at"))
        );
        var right = OneOf<DateReturning, DateArrayReturning>.FromT1(
            new DateArrayReturning(DateF("orders", "order_date"))
        );

        var diff = new EachDateDiffDays(left, right);
        var result = new NumberArrayReturning(diff);

        Assert.True(result.IsT4);
    }

    // ── per-row datetime math ─────────────────────────────────────────────────

    [Fact]
    public void EachDateTimeAddSeconds_ProducesDateTimeArrayReturning()
    {
        var left = OneOf<DateTimeReturning, DateTimeArrayReturning>.FromT1(
            new DateTimeArrayReturning(DtF("events", "started_at"))
        );
        var right = OneOf<NumberReturning, NumberArrayReturning>.FromT0(
            new NumberReturning(new NumberScalar(3600))
        );

        var addSeconds = new EachDateTimeAddSeconds(left, right);
        var result = new DateTimeArrayReturning(addSeconds);

        Assert.True(result.IsT3);
    }

    [Fact]
    public void EachDateTimeDiffSeconds_ProducesNumericArrayReturning()
    {
        var left = OneOf<DateTimeReturning, DateTimeArrayReturning>.FromT1(
            new DateTimeArrayReturning(DtF("orders", "shipped_at"))
        );
        var right = OneOf<DateTimeReturning, DateTimeArrayReturning>.FromT1(
            new DateTimeArrayReturning(DtF("orders", "ordered_at"))
        );

        var diff = new EachDateTimeDiffSeconds(left, right);
        var result = new NumberArrayReturning(diff);

        Assert.True(result.IsT5);
    }

    // ── per-row time math ─────────────────────────────────────────────────────

    [Fact]
    public void EachTimeAddSeconds_ProducesTimeArrayReturning()
    {
        var left = OneOf<TimeReturning, TimeArrayReturning>.FromT1(
            new TimeArrayReturning(TimeF("shifts", "clock_in"))
        );
        var right = OneOf<NumberReturning, NumberArrayReturning>.FromT0(
            new NumberReturning(new NumberScalar(28800))
        );

        var addSeconds = new EachTimeAddSeconds(left, right);
        var result = new TimeArrayReturning(addSeconds);

        Assert.True(result.IsT3);
    }

    [Fact]
    public void EachTimeDiffSeconds_ProducesNumericArrayReturning()
    {
        var left = OneOf<TimeReturning, TimeArrayReturning>.FromT1(
            new TimeArrayReturning(TimeF("shifts", "clock_out"))
        );
        var right = OneOf<TimeReturning, TimeArrayReturning>.FromT1(
            new TimeArrayReturning(TimeF("shifts", "clock_in"))
        );

        var diff = new EachTimeDiffSeconds(left, right);
        var result = new NumberArrayReturning(diff);

        Assert.True(result.IsT6);
    }

    // ── Query.Where accepts booleanArrayReturning ─────────────────────────────

    [Fact]
    public void Query_WhereAcceptsBooleanArrayReturning()
    {
        var from = new FromExpression("orders", "o");
        var select = new[] { new SelectExpression(new ArrayReturning(new NumberArrayReturning(NumF("orders", "id")))) };
        var whereExpr = new BooleanArrayReturning(
            new EachEquality(
                new EachStringEquality(
                    new StringArrayReturning(StrF("orders", "status")),
                    OneOf<StringReturning, StringArrayReturning>.FromT0(
                        new StringReturning(new StringScalar("pending"))
                    )
                )
            )
        );

        var query = new Query(
            from,
            select,
            OneOf<BooleanReturning, BooleanArrayReturning>.FromT1(whereExpr),
            null, null, null, null, null
        );

        Assert.NotNull(query.Where);
        Assert.True(query.Where!.Value.IsT1);
    }

    // ── Join.On accepts booleanArrayReturning ─────────────────────────────────

    [Fact]
    public void Join_OnAcceptsEachEqualCondition()
    {
        var on = new BooleanArrayReturning(
            new EachEquality(
                new EachNumberEquality(
                    new NumberArrayReturning(NumF("orders", "user_id")),
                    OneOf<NumberReturning, NumberArrayReturning>.FromT1(
                        new NumberArrayReturning(NumF("users", "id"))
                    )
                )
            )
        );

        var join = new Join(JoinType.Inner, "users", on);

        Assert.True(join.On.IsT1);
    }

    // ── aggregate in Returnings ───────────────────────────────────────────────

    [Fact]
    public void NumberReturning_IncludesAggregate()
    {
        var sumArg = new NumberArrayReturning(NumF("order_items", "price"));
        var sum = new SumNumber(sumArg);
        var aggregate = new NumberAggregate(sum);
        var returning = new NumberReturning(aggregate);

        Assert.True(returning.IsT3);
    }

    [Fact]
    public void NumberReturning_IncludesCount()
    {
        var countArg = new ArrayReturning(new NumberArrayReturning(NumF("orders", "id")));
        var count = new Count(countArg);
        var returning = new NumberReturning(count);

        Assert.True(returning.IsT4);
    }

    [Fact]
    public void NumberReturning_IncludesArithmetic()
    {
        var a = new NumberReturning(new NumberScalar(10));
        var b = new NumberReturning(new NumberScalar(5));
        var add = new Add(new[] { a, b });
        var arithmetic = new Arithmetic(add);
        var returning = new NumberReturning(arithmetic);

        Assert.True(returning.IsT2);
    }

    // ── schema gap fixes ──────────────────────────────────────────────────────

    [Fact]
    public void NullField_InFieldUnion_Constructs()
    {
        var nullField = new NullField("orders", "deleted_at");
        var field = new Field(nullField);

        Assert.Equal("orders", nullField.Entity);
        Assert.Equal("deleted_at", nullField.Field);
        Assert.True(field.IsT3);
    }

    [Fact]
    public void FromExpression_WithoutAlias_Constructs()
    {
        var from = new FromExpression("products");

        Assert.Equal("products", from.Entity);
        Assert.Null(from.Alias);
    }

    [Fact]
    public void Query_DistinctFlag_Constructs()
    {
        var from = new FromExpression("orders");
        var select = new[]
        {
            new SelectExpression(
                new SingleValueReturning(new NumberReturning(new NumberScalar(1))),
                "one"
            ),
        };

        var query = new Query(from, select, null, null, null, null, null, null, distinct: true);

        Assert.True(query.Distinct);
    }
}
