using OneOf;
using PureQL.CSharp.Model.Aggregates;
using PureQL.CSharp.Model.Aggregates.Numeric;
using PureQL.CSharp.Model.Arithmetics;
using PureQL.CSharp.Model.ArrayReturnings;
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

    private static NumberField NumF(string entity, string field)
    {
        return new(entity, field);
    }

    private static StringField StrF(string entity, string field)
    {
        return new(entity, field);
    }

    private static DateField DateF(string entity, string field)
    {
        return new(entity, field);
    }

    private static DateTimeField DtF(string entity, string field)
    {
        return new(entity, field);
    }

    private static TimeField TimeF(string entity, string field)
    {
        return new(entity, field);
    }

    private static UuidField UuidF(string entity, string field)
    {
        return new(entity, field);
    }

    private static BooleanField BoolF(string entity, string field)
    {
        return new(entity, field);
    }

    // ── basic query construction ──────────────────────────────────────────────

    [Fact]
    public void SimpleSelectConstructs()
    {
        FromExpression from = new FromExpression("orders", "o");
        SelectExpression[] select =
        [
            new SelectExpression(
                new SingleValueReturning(new NumberReturning(new NumberScalar(1))),
                "one"
            ),
        ];

        Query query = new Query(from, select);

        Assert.Equal("orders", query.From.Entity);
        _ = Assert.Single(query.SelectExpressions);
    }

    [Fact]
    public void QueryWithPaginationConstructs()
    {
        FromExpression from = new FromExpression("users", "u");
        SelectExpression[] select =
        [
            new SelectExpression(
                new ArrayReturning(new NumberArrayReturning(NumF("users", "id")))
            ),
        ];
        Pagination pagination = new Pagination(0, 10);

        Query query = new Query(from, select, null, null, null, null, null, pagination);

        Assert.NotNull(query.Pagination);
        Assert.Equal(0, query.Pagination!.Skip);
        Assert.Equal(10, query.Pagination!.Take);
    }

    // ── OrderBy with direction ────────────────────────────────────────────────

    [Fact]
    public void OrderByItemDefaultsToAsc()
    {
        OrderByItem item = new OrderByItem(new Field(NumF("orders", "amount")));

        Assert.Equal(SortDirection.Asc, item.Direction);
    }

    [Fact]
    public void OrderByItemExplicitDesc()
    {
        OrderByItem item = new OrderByItem(
            new Field(NumF("orders", "amount")),
            SortDirection.Desc
        );

        Assert.Equal(SortDirection.Desc, item.Direction);
    }

    [Fact]
    public void QueryWithOrderByItemConstructs()
    {
        FromExpression from = new FromExpression("orders", "o");
        SelectExpression[] select =
        [
            new SelectExpression(
                new ArrayReturning(new NumberArrayReturning(NumF("orders", "amount")))
            ),
        ];
        OrderByItem[] orderBy =
        [
            new OrderByItem(new Field(NumF("orders", "amount")), SortDirection.Desc),
        ];

        Query query = new Query(from, select, null, null, null, null, orderBy, null);

        _ = Assert.Single(query.OrderBy!);
        Assert.Equal(SortDirection.Desc, query.OrderBy!.First().Direction);
    }

    // ── each* equality ────────────────────────────────────────────────────────

    [Fact]
    public void EachNumberEqualityWithScalarRightConstructs()
    {
        NumberArrayReturning left = new NumberArrayReturning(
            NumF("orders", "status_code")
        );
        OneOf<NumberReturning, NumberArrayReturning> right = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT0(new NumberReturning(new NumberScalar(200)));

        EachNumberEquality equality = new EachNumberEquality(left, right);
        BooleanArrayReturning boolArray = new BooleanArrayReturning(
            new EachEquality(equality)
        );

        Assert.True(boolArray.IsT4);
    }

    [Fact]
    public void EachStringEqualityWithScalarRightConstructs()
    {
        StringArrayReturning left = new StringArrayReturning(StrF("users", "status"));
        OneOf<StringReturning, StringArrayReturning> right = OneOf<
            StringReturning,
            StringArrayReturning
        >.FromT0(new StringReturning(new StringScalar("active")));

        EachStringEquality equality = new EachStringEquality(left, right);
        BooleanArrayReturning boolArray = new BooleanArrayReturning(
            new EachEquality(equality)
        );

        Assert.True(boolArray.IsT4);
    }

    [Fact]
    public void EachUuidEqualityFieldToFieldConstructs()
    {
        UuidArrayReturning left = new UuidArrayReturning(UuidF("users", "id"));
        OneOf<UuidReturning, UuidArrayReturning> right = OneOf<
            UuidReturning,
            UuidArrayReturning
        >.FromT1(new UuidArrayReturning(UuidF("orders", "user_id")));

        EachUuidEquality equality = new EachUuidEquality(left, right);

        Assert.NotNull(equality);
    }

    [Fact]
    public void EachDateEqualityConstructs()
    {
        DateArrayReturning left = new DateArrayReturning(DateF("orders", "order_date"));
        OneOf<DateReturning, DateArrayReturning> right = OneOf<
            DateReturning,
            DateArrayReturning
        >.FromT0(new DateReturning(new DateScalar(new DateOnly(2024, 1, 1))));

        EachDateEquality equality = new EachDateEquality(left, right);

        Assert.NotNull(equality);
    }

    [Fact]
    public void EachBooleanEqualityConstructs()
    {
        BooleanArrayReturning left = new BooleanArrayReturning(
            BoolF("users", "is_active")
        );
        OneOf<BooleanReturning, BooleanArrayReturning> right = OneOf<
            BooleanReturning,
            BooleanArrayReturning
        >.FromT0(new BooleanReturning(new BooleanScalar(true)));

        EachBooleanEquality equality = new EachBooleanEquality(left, right);

        Assert.NotNull(equality);
    }

    [Fact]
    public void EachTimeEqualityConstructs()
    {
        TimeArrayReturning left = new TimeArrayReturning(TimeF("shifts", "start_time"));
        OneOf<TimeReturning, TimeArrayReturning> right = OneOf<
            TimeReturning,
            TimeArrayReturning
        >.FromT0(new TimeReturning(new TimeScalar(new TimeOnly(8, 0, 0))));

        EachTimeEquality equality = new EachTimeEquality(left, right);

        Assert.NotNull(equality);
    }

    [Fact]
    public void EachDateTimeEqualityConstructs()
    {
        DateTimeArrayReturning left = new DateTimeArrayReturning(
            DtF("events", "starts_at")
        );
        OneOf<DateTimeReturning, DateTimeArrayReturning> right = OneOf<
            DateTimeReturning,
            DateTimeArrayReturning
        >.FromT0(
            new DateTimeReturning(
                new DateTimeScalar(new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc))
            )
        );

        EachDateTimeEquality equality = new EachDateTimeEquality(left, right);

        Assert.NotNull(equality);
    }

    // ── each* comparisons ─────────────────────────────────────────────────────

    [Fact]
    public void EachNumberComparisonGreaterThanConstructs()
    {
        NumberArrayReturning left = new NumberArrayReturning(
            NumF("order_items", "unit_price")
        );
        OneOf<NumberReturning, NumberArrayReturning> right = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT0(new NumberReturning(new NumberScalar(100)));

        EachNumberComparison comparison = new EachNumberComparison(
            EachComparisonOperator.EachGreaterThan,
            left,
            right
        );
        BooleanArrayReturning boolArray = new BooleanArrayReturning(
            new EachComparison(comparison)
        );

        Assert.True(boolArray.IsT3);
    }

    [Fact]
    public void EachDateComparisonFieldToFieldConstructs()
    {
        DateArrayReturning left = new DateArrayReturning(DateF("orders", "shipped_at"));
        OneOf<DateReturning, DateArrayReturning> right = OneOf<
            DateReturning,
            DateArrayReturning
        >.FromT1(new DateArrayReturning(DateF("orders", "expected_at")));

        EachDateComparison comparison = new EachDateComparison(
            EachComparisonOperator.EachLessThan,
            left,
            right
        );

        Assert.Equal(EachComparisonOperator.EachLessThan, comparison.Operator);
    }

    [Fact]
    public void EachStringComparisonConstructs()
    {
        StringArrayReturning left = new StringArrayReturning(StrF("products", "name"));
        OneOf<StringReturning, StringArrayReturning> right = OneOf<
            StringReturning,
            StringArrayReturning
        >.FromT0(new StringReturning(new StringScalar("M")));

        EachStringComparison comparison = new EachStringComparison(
            EachComparisonOperator.EachGreaterThanOrEqual,
            left,
            right
        );

        Assert.NotNull(comparison);
    }

    [Fact]
    public void EachTimeComparisonConstructs()
    {
        TimeArrayReturning left = new TimeArrayReturning(TimeF("shifts", "clock_out"));
        OneOf<TimeReturning, TimeArrayReturning> right = OneOf<
            TimeReturning,
            TimeArrayReturning
        >.FromT0(new TimeReturning(new TimeScalar(new TimeOnly(17, 0, 0))));

        EachTimeComparison comparison = new EachTimeComparison(
            EachComparisonOperator.EachGreaterThan,
            left,
            right
        );

        Assert.NotNull(comparison);
    }

    [Fact]
    public void EachDateTimeComparisonConstructs()
    {
        DateTimeArrayReturning left = new DateTimeArrayReturning(
            DtF("orders", "shipped_at")
        );
        OneOf<DateTimeReturning, DateTimeArrayReturning> right = OneOf<
            DateTimeReturning,
            DateTimeArrayReturning
        >.FromT0(
            new DateTimeReturning(
                new DateTimeScalar(new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc))
            )
        );

        EachDateTimeComparison comparison = new EachDateTimeComparison(
            EachComparisonOperator.EachGreaterThan,
            left,
            right
        );

        Assert.NotNull(comparison);
    }

    // ── each* boolean operations ──────────────────────────────────────────────

    [Fact]
    public void EachAndOperatorComposesMultiplePredicates()
    {
        BooleanArrayReturning pred1 = new BooleanArrayReturning(
            new EachEquality(
                new EachStringEquality(
                    new StringArrayReturning(StrF("users", "status")),
                    OneOf<StringReturning, StringArrayReturning>.FromT0(
                        new StringReturning(new StringScalar("active"))
                    )
                )
            )
        );

        BooleanArrayReturning pred2 = new BooleanArrayReturning(
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

        EachAndOperator andOp = new EachAndOperator([pred1, pred2]);
        BooleanArrayReturning result = new BooleanArrayReturning(andOp);

        Assert.True(result.IsT5);
    }

    [Fact]
    public void EachOrOperatorConstructs()
    {
        BooleanArrayReturning pred1 = new BooleanArrayReturning(
            BoolF("users", "is_premium")
        );
        BooleanArrayReturning pred2 = new BooleanArrayReturning(
            BoolF("users", "is_admin")
        );

        EachOrOperator orOp = new EachOrOperator([pred1, pred2]);
        BooleanArrayReturning result = new BooleanArrayReturning(orOp);

        Assert.True(result.IsT6);
    }

    [Fact]
    public void EachNotOperatorConstructs()
    {
        BooleanArrayReturning inner = new BooleanArrayReturning(
            new EachEquality(
                new EachBooleanEquality(
                    new BooleanArrayReturning(BoolF("users", "is_deleted")),
                    OneOf<BooleanReturning, BooleanArrayReturning>.FromT0(
                        new BooleanReturning(new BooleanScalar(true))
                    )
                )
            )
        );

        EachNotOperator notOp = new EachNotOperator(inner);
        BooleanArrayReturning result = new BooleanArrayReturning(notOp);

        Assert.True(result.IsT7);
    }

    // ── per-row arithmetic ────────────────────────────────────────────────────

    [Fact]
    public void EachMultiplyFieldByScalarProducesNumericArrayReturning()
    {
        OneOf<NumberReturning, NumberArrayReturning> fieldArg = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT1(new NumberArrayReturning(NumF("order_items", "unit_price")));
        OneOf<NumberReturning, NumberArrayReturning> scalarArg = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT0(new NumberReturning(new NumberScalar(1.05)));

        EachMultiply multiply = new EachMultiply([fieldArg, scalarArg]);
        NumberArrayReturning result = new NumberArrayReturning(
            new EachArithmetic(multiply)
        );

        Assert.True(result.IsT3);
    }

    [Fact]
    public void EachAddThreeOperandsConstructs()
    {
        OneOf<NumberReturning, NumberArrayReturning> a = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT1(new NumberArrayReturning(NumF("items", "base_price")));
        OneOf<NumberReturning, NumberArrayReturning> b = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT1(new NumberArrayReturning(NumF("items", "tax")));
        OneOf<NumberReturning, NumberArrayReturning> c = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT1(new NumberArrayReturning(NumF("items", "shipping")));

        EachAdd add = new EachAdd([a, b, c]);

        Assert.Equal(3, add.Values.Count());
    }

    [Fact]
    public void EachSubtractConstructs()
    {
        OneOf<NumberReturning, NumberArrayReturning> a = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT1(new NumberArrayReturning(NumF("items", "price")));
        OneOf<NumberReturning, NumberArrayReturning> b = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT1(new NumberArrayReturning(NumF("items", "discount")));

        EachSubtract subtract = new EachSubtract([a, b]);
        NumberArrayReturning result = new NumberArrayReturning(
            new EachArithmetic(subtract)
        );

        Assert.True(result.IsT3);
    }

    [Fact]
    public void EachDivideConstructs()
    {
        OneOf<NumberReturning, NumberArrayReturning> a = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT1(new NumberArrayReturning(NumF("items", "total")));
        OneOf<NumberReturning, NumberArrayReturning> b = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT0(new NumberReturning(new NumberScalar(100)));

        EachDivide divide = new EachDivide([a, b]);

        Assert.NotNull(divide.Values);
    }

    // ── per-row date math ─────────────────────────────────────────────────────

    [Fact]
    public void EachDateAddDaysProducesDateArrayReturning()
    {
        OneOf<DateReturning, DateArrayReturning> left = OneOf<
            DateReturning,
            DateArrayReturning
        >.FromT1(new DateArrayReturning(DateF("orders", "order_date")));
        OneOf<NumberReturning, NumberArrayReturning> right = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT0(new NumberReturning(new NumberScalar(30)));

        EachDateAddDays addDays = new EachDateAddDays(left, right);
        DateArrayReturning result = new DateArrayReturning(addDays);

        Assert.True(result.IsT3);
    }

    [Fact]
    public void EachDateDiffDaysProducesNumericArrayReturning()
    {
        OneOf<DateReturning, DateArrayReturning> left = OneOf<
            DateReturning,
            DateArrayReturning
        >.FromT1(new DateArrayReturning(DateF("orders", "delivered_at")));
        OneOf<DateReturning, DateArrayReturning> right = OneOf<
            DateReturning,
            DateArrayReturning
        >.FromT1(new DateArrayReturning(DateF("orders", "order_date")));

        EachDateDiffDays diff = new EachDateDiffDays(left, right);
        NumberArrayReturning result = new NumberArrayReturning(diff);

        Assert.True(result.IsT4);
    }

    // ── per-row datetime math ─────────────────────────────────────────────────

    [Fact]
    public void EachDateTimeAddSecondsProducesDateTimeArrayReturning()
    {
        OneOf<DateTimeReturning, DateTimeArrayReturning> left = OneOf<
            DateTimeReturning,
            DateTimeArrayReturning
        >.FromT1(new DateTimeArrayReturning(DtF("events", "started_at")));
        OneOf<NumberReturning, NumberArrayReturning> right = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT0(new NumberReturning(new NumberScalar(3600)));

        EachDateTimeAddSeconds addSeconds = new EachDateTimeAddSeconds(left, right);
        DateTimeArrayReturning result = new DateTimeArrayReturning(addSeconds);

        Assert.True(result.IsT3);
    }

    [Fact]
    public void EachDateTimeDiffSecondsProducesNumericArrayReturning()
    {
        OneOf<DateTimeReturning, DateTimeArrayReturning> left = OneOf<
            DateTimeReturning,
            DateTimeArrayReturning
        >.FromT1(new DateTimeArrayReturning(DtF("orders", "shipped_at")));
        OneOf<DateTimeReturning, DateTimeArrayReturning> right = OneOf<
            DateTimeReturning,
            DateTimeArrayReturning
        >.FromT1(new DateTimeArrayReturning(DtF("orders", "ordered_at")));

        EachDateTimeDiffSeconds diff = new EachDateTimeDiffSeconds(left, right);
        NumberArrayReturning result = new NumberArrayReturning(diff);

        Assert.True(result.IsT5);
    }

    // ── per-row time math ─────────────────────────────────────────────────────

    [Fact]
    public void EachTimeAddSecondsProducesTimeArrayReturning()
    {
        OneOf<TimeReturning, TimeArrayReturning> left = OneOf<
            TimeReturning,
            TimeArrayReturning
        >.FromT1(new TimeArrayReturning(TimeF("shifts", "clock_in")));
        OneOf<NumberReturning, NumberArrayReturning> right = OneOf<
            NumberReturning,
            NumberArrayReturning
        >.FromT0(new NumberReturning(new NumberScalar(28800)));

        EachTimeAddSeconds addSeconds = new EachTimeAddSeconds(left, right);
        TimeArrayReturning result = new TimeArrayReturning(addSeconds);

        Assert.True(result.IsT3);
    }

    [Fact]
    public void EachTimeDiffSecondsProducesNumericArrayReturning()
    {
        OneOf<TimeReturning, TimeArrayReturning> left = OneOf<
            TimeReturning,
            TimeArrayReturning
        >.FromT1(new TimeArrayReturning(TimeF("shifts", "clock_out")));
        OneOf<TimeReturning, TimeArrayReturning> right = OneOf<
            TimeReturning,
            TimeArrayReturning
        >.FromT1(new TimeArrayReturning(TimeF("shifts", "clock_in")));

        EachTimeDiffSeconds diff = new EachTimeDiffSeconds(left, right);
        NumberArrayReturning result = new NumberArrayReturning(diff);

        Assert.True(result.IsT6);
    }

    // ── Query.Where accepts booleanArrayReturning ─────────────────────────────

    [Fact]
    public void QueryWhereAcceptsBooleanArrayReturning()
    {
        FromExpression from = new FromExpression("orders", "o");
        SelectExpression[] select =
        [
            new SelectExpression(
                new ArrayReturning(new NumberArrayReturning(NumF("orders", "id")))
            ),
        ];
        BooleanArrayReturning whereExpr = new BooleanArrayReturning(
            new EachEquality(
                new EachStringEquality(
                    new StringArrayReturning(StrF("orders", "status")),
                    OneOf<StringReturning, StringArrayReturning>.FromT0(
                        new StringReturning(new StringScalar("pending"))
                    )
                )
            )
        );

        Query query = new Query(
            from,
            select,
            OneOf<BooleanReturning, BooleanArrayReturning>.FromT1(whereExpr),
            null,
            null,
            null,
            null,
            null
        );

        _ = Assert.NotNull(query.Where);
        Assert.True(query.Where!.Value.IsT1);
    }

    // ── Join.On accepts booleanArrayReturning ─────────────────────────────────

    [Fact]
    public void JoinOnAcceptsEachEqualCondition()
    {
        BooleanArrayReturning on = new BooleanArrayReturning(
            new EachEquality(
                new EachNumberEquality(
                    new NumberArrayReturning(NumF("orders", "user_id")),
                    OneOf<NumberReturning, NumberArrayReturning>.FromT1(
                        new NumberArrayReturning(NumF("users", "id"))
                    )
                )
            )
        );

        Join join = new Join(JoinType.Inner, "users", on);

        Assert.True(join.On.IsT1);
    }

    // ── aggregate in Returnings ───────────────────────────────────────────────

    [Fact]
    public void NumberReturningIncludesAggregate()
    {
        NumberArrayReturning sumArg = new NumberArrayReturning(
            NumF("order_items", "price")
        );
        SumNumber sum = new SumNumber(sumArg);
        NumberAggregate aggregate = new NumberAggregate(sum);
        NumberReturning returning = new NumberReturning(aggregate);

        Assert.True(returning.IsT3);
    }

    [Fact]
    public void NumberReturningIncludesCount()
    {
        ArrayReturning countArg = new ArrayReturning(
            new NumberArrayReturning(NumF("orders", "id"))
        );
        Count count = new Count(countArg);
        NumberReturning returning = new NumberReturning(count);

        Assert.True(returning.IsT4);
    }

    [Fact]
    public void NumberReturningIncludesArithmetic()
    {
        NumberReturning a = new NumberReturning(new NumberScalar(10));
        NumberReturning b = new NumberReturning(new NumberScalar(5));
        Add add = new Add([a, b]);
        Arithmetic arithmetic = new Arithmetic(add);
        NumberReturning returning = new NumberReturning(arithmetic);

        Assert.True(returning.IsT2);
    }

    // ── schema gap fixes ──────────────────────────────────────────────────────

    [Fact]
    public void NullFieldInFieldUnionConstructs()
    {
        NullField nullField = new NullField("orders", "deleted_at");
        Field field = new Field(nullField);

        Assert.Equal("orders", nullField.Entity);
        Assert.Equal("deleted_at", nullField.Field);
        Assert.True(field.IsT3);
    }

    [Fact]
    public void FromExpressionWithoutAliasConstructs()
    {
        FromExpression from = new FromExpression("products");

        Assert.Equal("products", from.Entity);
        Assert.Null(from.Alias);
    }

    [Fact]
    public void QueryDistinctFlagConstructs()
    {
        FromExpression from = new FromExpression("orders");
        SelectExpression[] select =
        [
            new SelectExpression(
                new SingleValueReturning(new NumberReturning(new NumberScalar(1))),
                "one"
            ),
        ];

        Query query = new Query(
            from,
            select,
            null,
            null,
            null,
            null,
            null,
            null,
            distinct: true
        );

        Assert.True(query.Distinct);
    }
}
