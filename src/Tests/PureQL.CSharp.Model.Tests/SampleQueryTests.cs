using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.TotalExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Tests;

// Each test builds one of the specification samples and checks the shape it ends up in.
// Every node converts to the unions it may stand in, so a query reads like its JSON.
public sealed class SampleQueryTests
{
    [Fact]
    public void SelectSingleField()
    {
        // samples/valid/001_select_single_field.json
        PureQLQuery query = new MainPlainQueryWithoutPagination(
            new FromEntity("users"),
            [new SelectItemProjection("name", new FieldString("users", "name"))]
        );

        MainPlainQueryWithoutPagination plain =
            Assert.IsType<MainPlainQueryWithoutPagination>(query.Value);
        FromEntity from = Assert.IsType<FromEntity>(plain.From.Value);
        Assert.Equal("users", from.Entity);
        Assert.Null(from.Alias);
        SelectItemProjection column = Assert.Single(plain.Select);
        Assert.Equal("name", column.Alias);
        FieldString field = Assert.IsType<FieldString>(column.Expression.Value);
        Assert.Equal("users", field.Source);
        Assert.Equal("name", field.Field);
        Assert.Equal(new TypeString(), field.Type);
        Assert.Null(plain.Subqueries);
        Assert.Null(plain.Joins);
        Assert.Null(plain.Where);
        Assert.Null(plain.OrderBy);
        Assert.Null(plain.DistinctBy);
    }

    [Fact]
    public void DistinctByFirstRow()
    {
        // samples/valid/015_distinct_by_first_row.json
        FieldDatetime orderedAt = new FieldDatetime("orders", "ordered_at");
        MainPlainQueryWithoutPagination query = new MainPlainQueryWithoutPagination(
            new FromEntity("orders"),
            [
                new SelectItemProjection("user_id", new FieldUuid("orders", "user_id")),
                new SelectItemProjection("order_id", new FieldUuid("orders", "id")),
                new SelectItemProjection("ordered_at", orderedAt),
            ],
            distinctBy: ["user_id"],
            orderBy:
            [
                new OrderItemProjectionExpression(orderedAt, SortDirection.Desc),
                new OrderItemProjectionExpression(new FieldUuid("orders", "id")),
            ]
        );

        Assert.Equal("user_id", Assert.Single(query.DistinctBy!));
        OrderItemProjectionExpression latest =
            Assert.IsType<OrderItemProjectionExpression>(query.OrderBy!.First().Value);
        Assert.Equal(SortDirection.Desc, latest.Direction);
        Assert.Same(orderedAt, latest.Expression.Value);
        OrderItemProjectionExpression byId =
            Assert.IsType<OrderItemProjectionExpression>(query.OrderBy!.Last().Value);
        Assert.Equal(SortDirection.Asc, byId.Direction);
        Assert.Equal("id", Assert.IsType<FieldUuid>(byId.Expression.Value).Field);
    }

    [Fact]
    public void LeftJoinWithNullableColumns()
    {
        // samples/valid/071_left_join_nullable.json
        FieldUuidNullable couponId = new FieldUuidNullable("orders", "coupon_id");
        FieldDecimalNullable discount = new FieldDecimalNullable("coupons", "discount");
        MainPlainQueryWithoutPagination query = new MainPlainQueryWithoutPagination(
            new FromEntity("orders"),
            [
                new SelectItemProjection("id", new FieldUuid("orders", "id")),
                new SelectItemProjection(
                    "coupon_code",
                    new CoalesceStringProjection([
                        new FieldStringNullable("coupons", "code"),
                        new LiteralString("none"),
                    ])
                ),
                new SelectItemProjection(
                    "total_after_discount",
                    new SubtractDecimalNullableProjection([
                        new FieldDecimal("orders", "total"),
                        discount,
                    ])
                ),
            ],
            joins:
            [
                new JoinEntity(
                    JoinKind.Left,
                    "coupons",
                    new EqualUuidRow(couponId, new FieldUuid("coupons", "id"))
                ),
            ],
            where: new OrRow([
                new EqualUuidRow(couponId, new LiteralUuidNullable()),
                new GreaterThanDecimalRow(discount, new LiteralInteger(10)),
            ])
        );

        JoinEntity join = Assert.IsType<JoinEntity>(Assert.Single(query.Joins!).Value);
        Assert.Equal(JoinKind.Left, join.Kind);
        Assert.Equal("coupons", join.Entity);
        Assert.Null(join.Alias);

        CoalesceStringProjection coalesce = Assert.IsType<CoalesceStringProjection>(
            query.Select.ElementAt(1).Expression.Value
        );
        Assert.Equal(new TypeString(), coalesce.Type);
        Assert.Equal(2, coalesce.Values.Count());

        SubtractDecimalNullableProjection subtract =
            Assert.IsType<SubtractDecimalNullableProjection>(
                query.Select.Last().Expression.Value
            );
        Assert.Equal(new TypeDecimalNullable(), subtract.Type);
        Assert.Same(discount, subtract.Values.Last().Value);

        OrRow or = Assert.IsType<OrRow>(query.Where?.Value);
        BooleanRow[] conditions = [.. or.Conditions];
        Assert.Equal(2, conditions.Length);
        EqualUuidRow isNull = Assert.IsType<EqualUuidRow>(conditions[0].Value);
        Assert.Same(couponId, isNull.Left.Value);
        Assert.True(Assert.IsType<LiteralUuidNullable>(isNull.Right.Value).Type.Nullable);
        GreaterThanDecimalRow greater = Assert.IsType<GreaterThanDecimalRow>(
            conditions[1].Value
        );
        Assert.Equal(new TypeBoolean(), greater.Type);
        Assert.Equal(10L, Assert.IsType<LiteralInteger>(greater.Right.Value).Value);
    }

    [Fact]
    public void AggregatesOverAllRows()
    {
        // samples/valid/078_aggregates_over_all_rows.json
        FieldDecimal total = new FieldDecimal("orders", "total");
        PureQLQuery query = new MainTotalQuery(
            new FromEntity("orders"),
            [
                new SelectItemTotal("orders", new CountTotal()),
                new SelectItemTotal("revenue", new SumDecimalTotal(total)),
                new SelectItemTotal("smallest", new MinDecimalNullableTotal(total)),
                new SelectItemTotal(
                    "latest",
                    new MaxDatetimeNullableTotal(
                        new FieldDatetime("orders", "ordered_at")
                    )
                ),
                new SelectItemTotal("average", new AverageDecimalNullableTotal(total)),
                new SelectItemTotal(
                    "any_refund",
                    new AnyTotal(
                        new EqualStringRow(
                            new FieldString("orders", "status"),
                            new LiteralString("refunded")
                        )
                    )
                ),
                new SelectItemTotal(
                    "all_paid",
                    new AllTotal(new FieldBoolean("orders", "is_paid"))
                ),
            ]
        );

        MainTotalQuery main = Assert.IsType<MainTotalQuery>(query.Value);
        Assert.Null(main.Subqueries);
        Assert.Null(main.Joins);
        Assert.Null(main.Where);
        object?[] columns = [.. main.Aggregate.Select(c => c.Expression.Value)];
        Assert.Equal(7, columns.Length);

        CountTotal count = Assert.IsType<CountTotal>(columns[0]);
        Assert.Null(count.Predicate);
        Assert.Equal(new TypeInteger(), count.Type);

        SumDecimalTotal revenue = Assert.IsType<SumDecimalTotal>(columns[1]);
        Assert.False(revenue.Type.Nullable);
        Assert.Same(total, revenue.Selector.Value);

        MinDecimalNullableTotal smallest = Assert.IsType<MinDecimalNullableTotal>(
            columns[2]
        );
        Assert.Equal(new TypeDecimalNullable(), smallest.Type);

        MaxDatetimeNullableTotal latest = Assert.IsType<MaxDatetimeNullableTotal>(
            columns[3]
        );
        Assert.Equal(
            "ordered_at",
            Assert.IsType<FieldDatetime>(latest.Selector.Value).Field
        );

        AnyTotal anyRefund = Assert.IsType<AnyTotal>(columns[5]);
        EqualStringRow status = Assert.IsType<EqualStringRow>(anyRefund.Predicate.Value);
        Assert.Equal("refunded", Assert.IsType<LiteralString>(status.Right.Value).Value);
        AllTotal allPaid = Assert.IsType<AllTotal>(columns[6]);
        Assert.Equal(
            "is_paid",
            Assert.IsType<FieldBoolean>(allPaid.Predicate.Value).Field
        );
    }

    [Fact]
    public void GroupByCountWithHaving()
    {
        // samples/valid/085_having.json
        CountGroup count = new CountGroup();
        MainGroupedQueryWithoutPagination query = new MainGroupedQueryWithoutPagination(
            new FromEntity("orders"),
            [new GroupKey("user_id", new FieldUuid("orders", "user_id"))],
            [
                new SelectItemGroup("user_id", new KeyUuid("user_id")),
                new SelectItemGroup("orders", new CountGroup()),
            ],
            having: new GreaterThanOrEqualDecimalGroup(count, new LiteralInteger(5))
        );

        GroupKey key = Assert.Single(query.GroupBy);
        Assert.Equal("user_id", key.Alias);
        Assert.Equal("user_id", Assert.IsType<FieldUuid>(key.Expression.Value).Field);

        Assert.Equal(2, query.Select.Count());
        KeyUuid reference = Assert.IsType<KeyUuid>(query.Select.First().Expression.Value);
        Assert.Equal(key.Alias, reference.Key);
        Assert.Equal(new TypeUuid(), reference.Type);
        CountGroup selectedCount = Assert.IsType<CountGroup>(
            query.Select.Last().Expression.Value
        );
        Assert.Null(selectedCount.Predicate);
        Assert.Equal(AggregateOver.Group, selectedCount.Over);

        GreaterThanOrEqualDecimalGroup having =
            Assert.IsType<GreaterThanOrEqualDecimalGroup>(query.Having?.Value);
        Assert.Same(count, having.Left.Value);
        Assert.Equal(5L, Assert.IsType<LiteralInteger>(having.Right.Value).Value);
    }

    [Fact]
    public void InSubquery()
    {
        // samples/valid/101_in_subquery.json
        SubqueryQuery vipUsers = new SubqueryQuery(
            "vip_users",
            new PlainQueryWithoutPaginationWithoutOrderBy(
                new FromEntity("users"),
                [new SelectItemProjection("id", new FieldUuid("users", "id"))],
                where: new EqualStringRow(
                    new FieldString("users", "tier"),
                    new LiteralString("vip")
                )
            )
        );
        MainPlainQueryWithoutPagination query = new MainPlainQueryWithoutPagination(
            new FromEntity("orders"),
            [
                new SelectItemProjection("id", new FieldUuid("orders", "id")),
                new SelectItemProjection("total", new FieldDecimal("orders", "total")),
            ],
            subqueries: [vipUsers],
            where: new InUuidRow(
                new FieldUuid("orders", "user_id"),
                new ListSubqueryColumnUuid("vip_users", "id")
            )
        );

        SubqueryQuery subquery = Assert.IsType<SubqueryQuery>(
            Assert.Single(query.Subqueries!).Value
        );
        Assert.Equal("vip_users", subquery.Name);
        PlainQueryWithoutPaginationWithoutOrderBy plain =
            Assert.IsType<PlainQueryWithoutPaginationWithoutOrderBy>(
                subquery.Query.Value
            );
        EqualStringRow tier = Assert.IsType<EqualStringRow>(plain.Where?.Value);
        Assert.Equal("vip", Assert.IsType<LiteralString>(tier.Right.Value).Value);

        InUuidRow inVip = Assert.IsType<InUuidRow>(query.Where?.Value);
        Assert.Equal("user_id", Assert.IsType<FieldUuid>(inVip.Operand.Value).Field);
        ListSubqueryColumnUuid column = Assert.IsType<ListSubqueryColumnUuid>(
            inVip.List.Value
        );
        Assert.Equal("vip_users", column.Subquery);
        Assert.Equal("id", column.Field);
        Assert.Equal(new TypeUuid(), column.Type);
    }

    [Fact]
    public void PaginationRequiresOrderBy()
    {
        // Paginating a plain query is a variant of its own, with a required `orderBy`.
        MainPlainQueryWithPagination query = new MainPlainQueryWithPagination(
            new FromEntity("users"),
            new Pagination(new ParamInteger("skip"), 20),
            [new SelectItemProjection("name", new FieldString("users", "name"))],
            [new OrderItemProjectionExpression(new FieldString("users", "name"))]
        );

        Assert.Equal(
            "skip",
            Assert.IsType<ParamInteger>(query.Pagination.Skip?.Value).Param
        );
        Assert.Equal(20L, query.Pagination.Take?.Value);
        _ = Assert.Single(query.OrderBy);
    }

    [Fact]
    public void FirstPageHasNoSkip()
    {
        // samples/valid/016_filter_order_page.json: no rows skipped is no `skip`.
        Pagination firstPage = new Pagination(take: 20);

        Assert.Null(firstPage.Skip);
        Assert.Equal(20L, firstPage.Take?.Value);
    }

    [Fact]
    public void OrderByColumn()
    {
        // samples/valid/044_order_by_column.json
        FieldDecimal total = new FieldDecimal("orders", "total");
        MainGroupedQueryWithPagination query = new MainGroupedQueryWithPagination(
            new FromEntity("orders"),
            new Pagination(take: 10),
            [new GroupKey("user_id", new FieldUuid("orders", "user_id"))],
            [
                new SelectItemGroup("user_id", new KeyUuid("user_id")),
                new SelectItemGroup(
                    "paid_revenue",
                    new SumDecimalGroup(
                        total,
                        predicate: new FieldBoolean("orders", "is_paid")
                    )
                ),
                new SelectItemGroup(
                    "average_order",
                    new DivideDecimalGroup([new SumDecimalGroup(total), new CountGroup()])
                ),
            ],
            [
                new OrderItemGroupColumn("paid_revenue", SortDirection.Desc),
                new OrderItemGroupColumn("average_order", SortDirection.Desc),
                new OrderItemGroupColumn("user_id"),
            ]
        );

        OrderItemGroupColumn[] columns =
        [
            .. query.OrderBy.Select(o => Assert.IsType<OrderItemGroupColumn>(o.Value)),
        ];
        Assert.Equal(
            ["paid_revenue", "average_order", "user_id"],
            columns.Select(c => c.Column)
        );
        Assert.Equal(SortDirection.Asc, columns[2].Direction);
        DivideDecimalGroup average = Assert.IsType<DivideDecimalGroup>(
            query.Select.Last().Expression.Value
        );
        Assert.Equal(new TypeDecimal(), average.Type);
        _ = Assert.IsType<CountGroup>(average.Values.Last().Value);
    }

    [Fact]
    public void LocalDateParts()
    {
        // samples/valid/053_local_date_parts.json: the parts of a datetime in a zone.
        FieldDatetime orderedAt = new FieldDatetime("orders", "ordered_at");
        ParamString zone = new ParamString("zone");
        MainGroupedQueryWithoutPagination query = new MainGroupedQueryWithoutPagination(
            new FromEntity("orders"),
            [
                new GroupKey("weekday", new DayOfWeekDatetimeIntegerRow(orderedAt, zone)),
                new GroupKey("hour", new HourDatetimeIntegerRow(orderedAt, zone)),
            ],
            [
                new SelectItemGroup("weekday", new KeyInteger("weekday")),
                new SelectItemGroup("hour", new KeyInteger("hour")),
                new SelectItemGroup("orders", new CountGroup()),
                new SelectItemGroup(
                    "share_of_all_orders",
                    new DivideDecimalGroup([
                        new CountGroup(),
                        new CountGroup(over: AggregateOver.All),
                    ])
                ),
            ],
            where: new GreaterThanOrEqualDatetimeRow(
                orderedAt,
                new ParamDatetime("since")
            ),
            orderBy:
            [
                new OrderItemGroupColumn("weekday"),
                new OrderItemGroupColumn("hour"),
            ]
        );

        DayOfWeekDatetimeIntegerRow weekday = Assert.IsType<DayOfWeekDatetimeIntegerRow>(
            query.GroupBy.First().Expression.Value
        );
        Assert.Equal(new TypeInteger(), weekday.Type);
        Assert.Same(orderedAt, weekday.Operand.Value);
        Assert.Same(zone, weekday.Zone?.Value);
        // A date has no zone: its parts take none.
        Assert.Null(typeof(DayOfWeekDateIntegerRow).GetProperty("Zone"));
        DivideDecimalGroup share = Assert.IsType<DivideDecimalGroup>(
            query.Select.Last().Expression.Value
        );
        Assert.Equal(
            AggregateOver.All,
            Assert.IsType<CountGroup>(share.Values.Last().Value).Over
        );
    }

    [Fact]
    public void RoundingByDigitsAndMode()
    {
        // samples/valid/025_round_half_to_even.json; `round(1250, -2)` keeps an integer.
        FieldDecimal unitPrice = new FieldDecimal("order_items", "unit_price");
        FieldInteger quantity = new FieldInteger("order_items", "quantity");
        MainPlainQueryWithoutPagination query = new MainPlainQueryWithoutPagination(
            new FromEntity("order_items"),
            [
                new SelectItemProjection(
                    "whole_price_half_to_even",
                    new RoundWithoutDigitsIntegerProjection(
                        unitPrice,
                        RoundingMode.HalfEven
                    )
                ),
                new SelectItemProjection(
                    "line_total_in_hundreds",
                    new RoundDecimalProjection(
                        new MultiplyDecimalProjection([unitPrice, quantity]),
                        new LiteralInteger(-2),
                        RoundingMode.HalfEven
                    )
                ),
                new SelectItemProjection(
                    "quantity_in_tens",
                    new RoundWithDigitsIntegerProjection(quantity, new LiteralInteger(-1))
                ),
            ]
        );

        object?[] columns = [.. query.Select.Select(c => c.Expression.Value)];
        RoundWithoutDigitsIntegerProjection whole =
            Assert.IsType<RoundWithoutDigitsIntegerProjection>(columns[0]);
        Assert.Equal(new TypeInteger(), whole.Type);
        Assert.Equal(RoundingMode.HalfEven, whole.Mode);
        RoundDecimalProjection hundreds = Assert.IsType<RoundDecimalProjection>(
            columns[1]
        );
        Assert.Equal(new TypeDecimal(), hundreds.Type);
        Assert.Equal(-2L, Assert.IsType<LiteralInteger>(hundreds.Digits.Value).Value);
        RoundWithDigitsIntegerProjection tens =
            Assert.IsType<RoundWithDigitsIntegerProjection>(columns[2]);
        Assert.Equal(new TypeInteger(), tens.Type);
        Assert.Equal(RoundingMode.HalfAwayFromZero, tens.Mode);
    }

    [Fact]
    public void UnionAll()
    {
        // samples/valid/105_union_all.json
        SubqueryQuery events = new SubqueryQuery(
            "events",
            new CombinedQueryUnionAll([
                new PlainQueryWithoutPaginationWithoutOrderBy(
                    new FromEntity("orders"),
                    [
                        new SelectItemProjection(
                            "at",
                            new FieldDatetime("orders", "ordered_at")
                        ),
                        new SelectItemProjection("kind", new LiteralString("placed")),
                        new SelectItemProjection(
                            "amount",
                            new FieldDecimal("orders", "total")
                        ),
                    ]
                ),
                new PlainQueryWithoutPaginationWithoutOrderBy(
                    new FromEntity("users"),
                    [
                        new SelectItemProjection(
                            "at",
                            new FieldDatetime("users", "created_at")
                        ),
                        new SelectItemProjection("kind", new LiteralString("signed up")),
                        new SelectItemProjection("amount", new LiteralDecimalNullable()),
                    ]
                ),
            ])
        );
        FieldDatetime at = new FieldDatetime("events", "at");
        PureQLQuery query = new MainPlainQueryWithPagination(
            new FromSubquery("events"),
            new Pagination(take: 50),
            [
                new SelectItemProjection("at", at),
                new SelectItemProjection(
                    "amount",
                    new FieldDecimalNullable("events", "amount")
                ),
            ],
            [new OrderItemProjectionExpression(at, SortDirection.Desc)],
            subqueries: [events],
            where: new GreaterThanOrEqualDatetimeRow(at, new ParamDatetime("since"))
        );

        MainPlainQueryWithPagination main = Assert.IsType<MainPlainQueryWithPagination>(
            query.Value
        );
        SubqueryQuery subquery = Assert.IsType<SubqueryQuery>(
            Assert.Single(main.Subqueries!).Value
        );
        CombinedQueryUnionAll union = Assert.IsType<CombinedQueryUnionAll>(
            subquery.Query.Value
        );
        Assert.Equal(2, union.UnionAll.Count());
        PlainQueryWithoutPaginationWithoutOrderBy signups =
            Assert.IsType<PlainQueryWithoutPaginationWithoutOrderBy>(
                union.UnionAll.Last().Value
            );
        Assert.True(
            Assert.IsType<LiteralDecimalNullable>(signups.Select.Last().Expression.Value)
                .Type.Nullable
        );
    }

    [Fact]
    public void InlineRows()
    {
        // samples/valid/107_inline_rows.json
        SubqueryRows statuses = new SubqueryRows(
            "statuses",
            [
                [
                    new RowItem("status", new LiteralString("new")),
                    new RowItem("rank", new LiteralInteger(1)),
                    new RowItem("label", new LiteralString("New")),
                ],
                [
                    new RowItem("status", new LiteralString("cancelled")),
                    new RowItem("rank", new LiteralInteger(4)),
                    new RowItem("label", new LiteralStringNullable()),
                ],
            ]
        );
        MainPlainQueryWithoutPagination query = new MainPlainQueryWithoutPagination(
            new FromEntity("orders"),
            [
                new SelectItemProjection("id", new FieldUuid("orders", "id")),
                new SelectItemProjection(
                    "status",
                    new CoalesceStringProjection([
                        new FieldStringNullable("statuses", "label"),
                        new FieldString("orders", "status"),
                    ])
                ),
            ],
            subqueries: [statuses],
            joins:
            [
                new JoinSubquery(
                    JoinKind.Left,
                    "statuses",
                    new EqualStringRow(
                        new FieldString("orders", "status"),
                        new FieldString("statuses", "status")
                    )
                ),
            ]
        );

        SubqueryRows rows = Assert.IsType<SubqueryRows>(
            Assert.Single(query.Subqueries!).Value
        );
        Assert.Equal("statuses", rows.Name);
        RowItem[][] cells = [.. rows.Rows.Select(r => r.ToArray())];
        Assert.Equal(2, cells.Length);
        Assert.Equal(
            1L,
            Assert.IsType<LiteralInteger>(cells[0][1].Expression.Value).Value
        );
        _ = Assert.IsType<LiteralStringNullable>(cells[1][2].Expression.Value);
        Assert.Equal(
            "statuses",
            Assert.IsType<JoinSubquery>(Assert.Single(query.Joins!).Value).Subquery
        );
    }

    [Fact]
    public void RangeFrames()
    {
        // samples/valid/111_range_frames.json
        FieldUuid userId = new FieldUuid("orders", "user_id");
        FieldDate orderDate = new FieldDate("orders", "order_date");
        FieldDecimal total = new FieldDecimal("orders", "total");
        MainPlainQueryWithoutPagination query = new MainPlainQueryWithoutPagination(
            new FromEntity("orders"),
            [
                new SelectItemProjection(
                    "spent_in_last_30_days",
                    new SumDecimalProjection(
                        total,
                        over: new WindowWithoutFrameWithRangeDate(
                            [new OrderItemDateRow(orderDate)],
                            new RangeDate(preceding: new DistanceDateDays(29L)),
                            partitionBy: [userId]
                        )
                    )
                ),
                new SelectItemProjection(
                    "balance_to_date",
                    new SumDecimalProjection(
                        total,
                        over: new WindowWithoutFrameWithRangeDate(
                            [new OrderItemDateRow(orderDate)],
                            new RangeDate(preceding: new All()),
                            partitionBy: [userId]
                        )
                    )
                ),
                new SelectItemProjection(
                    "orders_of_similar_size",
                    new CountProjection(
                        over: new WindowWithoutFrameWithRangeDecimal(
                            [new OrderItemDecimalRow(total)],
                            new RangeDecimal(
                                preceding: 10L,
                                following: new LiteralDecimal(9.99m)
                            )
                        )
                    )
                ),
            ]
        );

        object?[] columns = [.. query.Select.Select(c => c.Expression.Value)];
        SumDecimalProjection last30Days = Assert.IsType<SumDecimalProjection>(columns[0]);
        WindowWithoutFrameWithRangeDate window =
            Assert.IsType<WindowWithoutFrameWithRangeDate>(last30Days.Over?.Value);
        Assert.Same(userId, Assert.Single(window.PartitionBy!).Value);
        Assert.Same(orderDate, Assert.Single(window.OrderBy).Expression.Value);
        DistanceDateDays days = Assert.IsType<DistanceDateDays>(
            window.Range.Preceding?.Value
        );
        Assert.Equal(29L, days.Days.Value);
        Assert.Null(window.Range.Following);
        _ = Assert.IsType<All>(
            Assert.IsType<WindowWithoutFrameWithRangeDate>(
                Assert.IsType<SumDecimalProjection>(columns[1]).Over?.Value
            ).Range.Preceding?.Value
        );
        CountProjection similar = Assert.IsType<CountProjection>(columns[2]);
        RangeDecimal range = Assert.IsType<WindowWithoutFrameWithRangeDecimal>(
            similar.Over?.Value
        ).Range;
        Assert.Equal(10L, range.Preceding?.Value);
        Assert.Equal(
            9.99m,
            Assert.IsType<LiteralDecimal>(range.Following?.Value).Value
        );
    }

    [Fact]
    public void PreviousAndNext()
    {
        // samples/valid/113_previous_next.json
        FieldDecimal total = new FieldDecimal("orders", "total");
        OrderedWindow byOrder = new OrderedWindow(
            [
                new OrderItemRow(new FieldDatetime("orders", "ordered_at")),
                new OrderItemRow(new FieldUuid("orders", "id")),
            ],
            partitionBy: [new FieldUuid("orders", "user_id")]
        );
        MainPlainQueryWithoutPagination query = new MainPlainQueryWithoutPagination(
            new FromEntity("orders"),
            [
                new SelectItemProjection(
                    "previous_total",
                    new PreviousDecimalNullableProjection(total, byOrder)
                ),
                new SelectItemProjection(
                    "change_from_zero",
                    new SubtractDecimalProjection([
                        total,
                        new PreviousDecimalProjection(
                            total,
                            new LiteralInteger(0),
                            byOrder
                        ),
                    ])
                ),
                new SelectItemProjection("rank", new RankProjection(byOrder)),
            ]
        );

        object?[] columns = [.. query.Select.Select(c => c.Expression.Value)];
        PreviousDecimalNullableProjection previous =
            Assert.IsType<PreviousDecimalNullableProjection>(columns[0]);
        Assert.Equal(new TypeDecimalNullable(), previous.Type);
        Assert.Null(previous.Default);
        Assert.Null(previous.Offset);
        Assert.Same(byOrder, previous.Over);
        SubtractDecimalProjection change = Assert.IsType<SubtractDecimalProjection>(
            columns[1]
        );
        PreviousDecimalProjection fromZero = Assert.IsType<PreviousDecimalProjection>(
            change.Values.Last().Value
        );
        Assert.Equal(new TypeDecimal(), fromZero.Type);
        Assert.Equal(0L, Assert.IsType<LiteralInteger>(fromZero.Default.Value).Value);
        Assert.Equal(new TypeInteger(), Assert.IsType<RankProjection>(columns[2]).Type);
    }

    [Fact]
    public void RecursiveSubquery()
    {
        // samples/valid/117_descendants.json
        SubqueryRecursive referrals = new SubqueryRecursive(
            "referrals",
            new Recursion(
                new PlainQueryWithoutPaginationWithoutOrderBy(
                    new FromEntity("users"),
                    [
                        new SelectItemProjection("id", new FieldUuid("users", "id")),
                        new SelectItemProjection("depth", new LiteralInteger(0)),
                    ],
                    where: new EqualUuidRow(
                        new FieldUuid("users", "id"),
                        new ParamUuid("user_id")
                    )
                ),
                new PlainNextQuery(
                    new FromEntity("users"),
                    [
                        new SelectItemRow("id", new FieldUuid("users", "id")),
                        new SelectItemRow(
                            "depth",
                            new AddIntegerRow([
                                new FieldInteger("referrals", "depth"),
                                new LiteralInteger(1),
                            ])
                        ),
                    ],
                    joins:
                    [
                        new JoinSubquery(
                            JoinKind.Inner,
                            "referrals",
                            new EqualUuidRow(
                                new FieldUuidNullable("users", "referrer_id"),
                                new FieldUuid("referrals", "id")
                            )
                        ),
                    ]
                ),
                50L
            )
        );
        MainPlainQueryWithoutPagination query = new MainPlainQueryWithoutPagination(
            new FromSubquery("referrals"),
            [new SelectItemProjection("id", new FieldUuid("referrals", "id"))],
            subqueries: [referrals],
            where: new GreaterThanDecimalRow(
                new FieldInteger("referrals", "depth"),
                new LiteralInteger(0)
            )
        );

        SubqueryRecursive recursive = Assert.IsType<SubqueryRecursive>(
            Assert.Single(query.Subqueries!).Value
        );
        Assert.Equal(50L, recursive.Recursive.MaxDepth.Value);
        _ = Assert.IsType<PlainQueryWithoutPaginationWithoutOrderBy>(
            recursive.Recursive.Seed.Value
        );
        PlainNextQuery next = Assert.IsType<PlainNextQuery>(
            recursive.Recursive.Next.Value
        );
        AddIntegerRow depth = Assert.IsType<AddIntegerRow>(
            next.Select.Last().Expression.Value
        );
        Assert.Equal(new TypeInteger(), depth.Type);
    }

    [Fact]
    public void UnionsSwitchExhaustively()
    {
        // A union's cases are known to the compiler: no discard arm is needed.
        static string Describe(From from)
        {
            return from switch
            {
                FromEntity entity => "entity " + entity.Entity,
                FromSubquery subquery => "subquery " + subquery.Subquery,
                _ => throw new NotImplementedException(),
            };
        }

        Assert.Equal("entity users", Describe(new FromEntity("users")));
        Assert.Equal("subquery vip_users", Describe(new FromSubquery("vip_users", "v")));
    }
}
