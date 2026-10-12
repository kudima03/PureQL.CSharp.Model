using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.GroupKeys;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.SelectItems;
using PureQL.CSharp.Model.TotalExpressions;

namespace PureQL.CSharp.Model.Tests;

// Each test builds one of the specification samples and checks the shape it ends up in.
public sealed class SampleQueryTests
{
    private static From Entity(string entity)
    {
        return new From(new FromEntity(entity));
    }

    private static SelectItemProjection Column(string alias, StringProjection expression)
    {
        return new SelectItemProjection(
            new SelectItemProjectionNonNullable(
                new SelectItemProjectionString(alias, expression)
            )
        );
    }

    private static SelectItemProjection Column(string alias, UuidProjection expression)
    {
        return new SelectItemProjection(
            new SelectItemProjectionNonNullable(
                new SelectItemProjectionUuid(alias, expression)
            )
        );
    }

    private static SelectItemProjection Column(
        string alias,
        DatetimeProjection expression
    )
    {
        return new SelectItemProjection(
            new SelectItemProjectionNonNullable(
                new SelectItemProjectionDatetime(alias, expression)
            )
        );
    }

    private static SelectItemProjection Column(
        string alias,
        ExactDecimalProjection expression
    )
    {
        return new SelectItemProjection(
            new SelectItemProjectionNonNullable(
                new SelectItemProjectionDecimal(alias, expression)
            )
        );
    }

    private static BooleanRow EqualString(StringRow left, StringRow right)
    {
        return new BooleanRow(
            new ComparisonRow(
                new EqualRow(
                    new EqualStringRow(
                        new StringNullableRow(left),
                        new StringNullableRow(right)
                    )
                )
            )
        );
    }

    [Fact]
    public void SelectSingleField()
    {
        // samples/01_select_single_field.json
        PureQLQuery query = new PureQLQuery(
            new MainPlainQuery(
                Entity("users"),
                [Column("name", new StringProjection(new FieldString("users", "name")))]
            )
        );

        MainPlainQuery plain = query.AsT1;
        Assert.Equal("users", plain.From.AsT0.Entity);
        Assert.Null(plain.From.AsT0.Alias);
        SelectItemProjectionString column = Assert.Single(plain.Select).AsT0.AsT2;
        Assert.Equal("name", column.Alias);
        Assert.Equal("string", column.Type.Name);
        Assert.False(column.Type.Nullable);
        FieldString field = column.Expression.AsT0;
        Assert.Equal("users", field.Source);
        Assert.Equal("name", field.Field);
        Assert.Null(plain.Subqueries);
        Assert.Null(plain.Joins);
        Assert.Null(plain.Where);
        Assert.Null(plain.OrderBy);
        Assert.Null(plain.Pagination);
        Assert.Null(plain.DistinctBy);
    }

    [Fact]
    public void DistinctByFirstRow()
    {
        // samples/14_distinct_by_first_row.json
        FieldDatetime orderedAt = new FieldDatetime("orders", "ordered_at");
        MainPlainQuery query = new MainPlainQuery(
            Entity("orders"),
            [
                Column("user_id", new UuidProjection(new FieldUuid("orders", "user_id"))),
                Column("order_id", new UuidProjection(new FieldUuid("orders", "id"))),
                Column("ordered_at", new DatetimeProjection(orderedAt)),
            ],
            subqueries: null,
            joins: null,
            where: null,
            orderBy:
            [
                new OrderItemProjection(
                    new ExprProjection(
                        new DatetimeNullableProjection(new DatetimeProjection(orderedAt))
                    ),
                    SortDirection.Desc
                ),
                new OrderItemProjection(
                    new ExprProjection(
                        new UuidNullableProjection(
                            new UuidProjection(new FieldUuid("orders", "id"))
                        )
                    )
                ),
            ],
            pagination: null,
            distinctBy: ["user_id"]
        );

        Assert.Equal("user_id", Assert.Single(query.DistinctBy!));
        OrderItemProjection latest = query.OrderBy!.First();
        Assert.Equal(SortDirection.Desc, latest.Direction);
        Assert.Same(orderedAt, latest.Expression.AsT5.AsT0.AsT0);
        OrderItemProjection byId = query.OrderBy!.Last();
        Assert.Equal(SortDirection.Asc, byId.Direction);
        Assert.Equal("id", byId.Expression.AsT6.AsT0.AsT0.Field);
    }

    [Fact]
    public void LeftJoinWithNullableColumns()
    {
        // samples/32_left_join_nullable.json
        FieldUuidNullable couponId = new FieldUuidNullable("orders", "coupon_id");
        MainPlainQuery query = new MainPlainQuery(
            Entity("orders"),
            [
                Column("id", new UuidProjection(new FieldUuid("orders", "id"))),
                Column(
                    "coupon_code",
                    new StringProjection(
                        new ConditionalStringProjection(
                            new CoalesceStringProjection([
                                new StringNullableProjection(
                                    new ExactStringNullableProjection(
                                        new FieldStringNullable("coupons", "code")
                                    )
                                ),
                                new StringNullableProjection(
                                    new StringProjection(new LiteralString("none"))
                                ),
                            ])
                        )
                    )
                ),
                new SelectItemProjection(
                    new SelectItemProjectionNullable(
                        new SelectItemProjectionDecimalNullable(
                            "total_after_discount",
                            new ExactDecimalNullableProjection(
                                new ArithmeticDecimalNullableProjection(
                                    new SubtractDecimalNullableProjection([
                                        new DecimalNullableProjection(
                                            new ExactDecimalProjection(
                                                new FieldDecimal("orders", "total")
                                            )
                                        ),
                                        new DecimalNullableProjection(
                                            new ExactDecimalNullableProjection(
                                                new FieldDecimalNullable(
                                                    "coupons",
                                                    "discount"
                                                )
                                            )
                                        ),
                                    ])
                                )
                            )
                        )
                    )
                ),
            ],
            subqueries: null,
            joins:
            [
                new Join(
                    new JoinEntity(
                        JoinKind.Left,
                        "coupons",
                        new BooleanRow(
                            new ComparisonRow(
                                new EqualRow(
                                    new EqualUuidRow(
                                        new UuidNullableRow(
                                            new ExactUuidNullableRow(couponId)
                                        ),
                                        new UuidNullableRow(
                                            new UuidRow(new FieldUuid("coupons", "id"))
                                        )
                                    )
                                )
                            )
                        )
                    )
                ),
            ],
            where: new BooleanRow(
                new LogicalRow(
                    new OrRow([
                        new BooleanRow(
                            new ComparisonRow(
                                new EqualRow(
                                    new EqualUuidRow(
                                        new UuidNullableRow(
                                            new ExactUuidNullableRow(couponId)
                                        ),
                                        new UuidNullableRow(
                                            new ExactUuidNullableRow(
                                                new LiteralUuidNullable()
                                            )
                                        )
                                    )
                                )
                            )
                        ),
                        new BooleanRow(
                            new ComparisonRow(
                                new GreaterThanRow(
                                    new GreaterThanDecimalRow(
                                        new DecimalNullableRow(
                                            new ExactDecimalNullableRow(
                                                new FieldDecimalNullable(
                                                    "coupons",
                                                    "discount"
                                                )
                                            )
                                        ),
                                        new DecimalNullableRow(
                                            new IntegerRow(new LiteralInteger(10))
                                        )
                                    )
                                )
                            )
                        ),
                    ])
                )
            ),
            orderBy: null,
            pagination: null,
            distinctBy: null
        );

        JoinEntity join = Assert.Single(query.Joins!).AsT0;
        Assert.Equal(JoinKind.Left, join.Kind);
        Assert.Equal("coupons", join.Entity);
        Assert.Null(join.Alias);

        CoalesceStringProjection coalesce = query
            .Select.ElementAt(1)
            .AsT0.AsT2.Expression.AsT4.AsT1;
        Assert.Equal("string", coalesce.Type.Name);
        Assert.False(coalesce.Type.Nullable);

        SelectItemProjectionDecimalNullable total = query.Select.Last().AsT1.AsT1;
        Assert.True(total.Type.Nullable);
        Assert.Equal("decimal", total.Type.Name);
        SubtractDecimalNullableProjection subtract = total.Expression.AsT3.AsT1;
        Assert.Equal(total.Type, subtract.Type);
        Assert.Equal(2, subtract.Values.Count());

        BooleanRow[] conditions = [.. query.Where!.AsT3.AsT1.Conditions];
        Assert.Equal(2, conditions.Length);
        EqualUuidRow isNull = conditions[0].AsT4.AsT0.AsT6;
        Assert.Same(couponId, isNull.Left.AsT1.AsT0);
        Assert.True(isNull.Right.AsT1.AsT2.Type.Nullable);
        GreaterThanDecimalRow discount = conditions[1].AsT4.AsT3.AsT0;
        Assert.Equal("boolean", discount.Type.Name);
        Assert.Equal(10L, discount.Right.AsT2.AsT2.Value);
    }

    [Fact]
    public void AggregatesOverAllRows()
    {
        // samples/39_aggregates_over_all_rows.json
        DecimalNullableRow total = new DecimalNullableRow(
            new ExactDecimalRow(new FieldDecimal("orders", "total"))
        );
        PureQLQuery query = new PureQLQuery(
            new MainTotalQuery(
                Entity("orders"),
                [
                    new SelectItemTotal(
                        new SelectItemTotalNonNullable(
                            new SelectItemTotalInteger(
                                "orders",
                                new IntegerTotal(
                                    new AggregateIntegerTotal(new CountTotal())
                                )
                            )
                        )
                    ),
                    new SelectItemTotal(
                        new SelectItemTotalNonNullable(
                            new SelectItemTotalDecimal(
                                "revenue",
                                new ExactDecimalTotal(new SumDecimalTotal(total))
                            )
                        )
                    ),
                    new SelectItemTotal(
                        new SelectItemTotalNullable(
                            new SelectItemTotalDecimalNullable(
                                "smallest",
                                new ExactDecimalNullableTotal(
                                    new AggregateDecimalNullableTotal(
                                        new MinDecimalNullableTotal(total)
                                    )
                                )
                            )
                        )
                    ),
                    new SelectItemTotal(
                        new SelectItemTotalNullable(
                            new SelectItemTotalDatetimeNullable(
                                "latest",
                                new ExactDatetimeNullableTotal(
                                    new AggregateDatetimeNullableTotal(
                                        new MaxDatetimeNullableTotal(
                                            new DatetimeNullableRow(
                                                new DatetimeRow(
                                                    new FieldDatetime(
                                                        "orders",
                                                        "ordered_at"
                                                    )
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    ),
                    new SelectItemTotal(
                        new SelectItemTotalNullable(
                            new SelectItemTotalDecimalNullable(
                                "average",
                                new ExactDecimalNullableTotal(
                                    new AggregateDecimalNullableTotal(
                                        new AverageDecimalNullableTotal(total)
                                    )
                                )
                            )
                        )
                    ),
                    new SelectItemTotal(
                        new SelectItemTotalNonNullable(
                            new SelectItemTotalBoolean(
                                "any_refund",
                                new BooleanTotal(
                                    new AggregateBooleanTotal(
                                        new AnyTotal(
                                            EqualString(
                                                new StringRow(
                                                    new FieldString("orders", "status")
                                                ),
                                                new StringRow(
                                                    new LiteralString("refunded")
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    ),
                    new SelectItemTotal(
                        new SelectItemTotalNonNullable(
                            new SelectItemTotalBoolean(
                                "all_paid",
                                new BooleanTotal(
                                    new AggregateBooleanTotal(
                                        new AllTotal(
                                            new BooleanRow(
                                                new FieldBoolean("orders", "is_paid")
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    ),
                ]
            )
        );

        MainTotalQuery main = query.AsT2;
        Assert.Null(main.Subqueries);
        Assert.Null(main.Joins);
        Assert.Null(main.Where);
        SelectItemTotal[] columns = [.. main.Aggregate];
        Assert.Equal(7, columns.Length);

        CountTotal count = columns[0].AsT0.AsT0.Expression.AsT6.AsT0;
        Assert.Null(count.Predicate);
        Assert.Equal("integer", count.Type.Name);

        SumDecimalTotal revenue = columns[1].AsT0.AsT1.Expression.AsT6;
        Assert.False(revenue.Type.Nullable);
        Assert.Same(total, revenue.Selector);

        SelectItemTotalDecimalNullable smallest = columns[2].AsT1.AsT1;
        Assert.True(smallest.Type.Nullable);
        Assert.Equal(smallest.Type, smallest.Expression.AsT6.AsT1.Type);

        MaxDatetimeNullableTotal latest = columns[3].AsT1.AsT6.Expression.AsT4.AsT2;
        Assert.Equal("ordered_at", latest.Selector.AsT0.AsT0.Field);

        AnyTotal anyRefund = columns[5].AsT0.AsT3.Expression.AsT5.AsT0;
        Assert.Equal(
            "refunded",
            anyRefund.Predicate.AsT4.AsT0.AsT1.Right.AsT0.AsT2.Value
        );
        AllTotal allPaid = columns[6].AsT0.AsT3.Expression.AsT5.AsT1;
        Assert.Equal("is_paid", allPaid.Predicate.AsT0.Field);
    }

    [Fact]
    public void GroupByCountWithHaving()
    {
        // samples/45_having.json
        CountGroup count = new CountGroup();
        MainGroupedQuery query = new MainGroupedQuery(
            Entity("orders"),
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
            [
                new SelectItemGroup(
                    new SelectItemGroupNonNullable(
                        new SelectItemGroupUuid(
                            "user_id",
                            new UuidGroup(new KeyUuid("user_id"))
                        )
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
                                new IntegerGroup(new AggregateIntegerGroup(count))
                            ),
                            new DecimalNullableGroup(
                                new IntegerGroup(new LiteralInteger(5))
                            )
                        )
                    )
                )
            ),
            orderBy: null,
            pagination: null,
            distinctBy: null
        );

        GroupKeyUuid key = Assert.Single(query.GroupBy).AsT0.AsT7;
        Assert.Equal("user_id", key.Alias);
        Assert.Equal("uuid", key.Type.Name);
        Assert.Equal("user_id", key.Expression.AsT0.Field);

        Assert.Equal(2, query.Select.Count());
        KeyUuid reference = query.Select.First().AsT0.AsT7.Expression.AsT0;
        Assert.Equal(key.Alias, reference.Key);
        Assert.Equal(key.Type, reference.Type);
        CountGroup selectedCount = query.Select.Last().AsT0.AsT0.Expression.AsT7.AsT0;
        Assert.Null(selectedCount.Predicate);
        Assert.Equal(AggregateOver.Group, selectedCount.Over);

        GreaterThanOrEqualDecimalGroup having = query.Having!.AsT4.AsT5.AsT0;
        Assert.Same(count, having.Left.AsT2.AsT7.AsT0);
        Assert.Equal(5L, having.Right.AsT2.AsT2.Value);
    }

    [Fact]
    public void InSubquery()
    {
        // samples/54_in_subquery.json
        Subquery vipUsers = new Subquery(
            "vip_users",
            new Query(
                new PlainQuery(
                    Entity("users"),
                    [Column("id", new UuidProjection(new FieldUuid("users", "id")))],
                    joins: null,
                    where: EqualString(
                        new StringRow(new FieldString("users", "tier")),
                        new StringRow(new LiteralString("vip"))
                    ),
                    orderBy: null,
                    pagination: null,
                    distinctBy: null
                )
            )
        );
        MainPlainQuery query = new MainPlainQuery(
            Entity("orders"),
            [
                Column("id", new UuidProjection(new FieldUuid("orders", "id"))),
                Column(
                    "total",
                    new ExactDecimalProjection(new FieldDecimal("orders", "total"))
                ),
            ],
            subqueries: [vipUsers],
            joins: null,
            where: new BooleanRow(
                new ComparisonRow(
                    new InRow(
                        new InUuidRow(
                            new UuidNullableRow(
                                new UuidRow(new FieldUuid("orders", "user_id"))
                            ),
                            new ListUuid(new ListSubqueryColumnUuid("vip_users", "id"))
                        )
                    )
                )
            ),
            orderBy: null,
            pagination: null,
            distinctBy: null
        );

        Subquery subquery = Assert.Single(query.Subqueries!);
        Assert.Equal("vip_users", subquery.Name);
        Assert.True(subquery.Query.IsT1);
        EqualStringRow tier = subquery.Query.AsT1.Where!.AsT4.AsT0.AsT1;
        Assert.Equal("vip", tier.Right.AsT0.AsT2.Value);

        InUuidRow inVip = query.Where!.AsT4.AsT2.AsT6;
        Assert.Equal("user_id", inVip.Operand.AsT0.AsT0.Field);
        ListSubqueryColumnUuid column = inVip.List.AsT2;
        Assert.Equal("vip_users", column.Subquery);
        Assert.Equal("id", column.Field);
        Assert.False(column.Nullable);
        Assert.Equal("uuid", column.Type.Name);
    }
}
