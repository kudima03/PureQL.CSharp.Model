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
        // samples/01_select_single_field.json
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
        // samples/14_distinct_by_first_row.json
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
                new OrderItemProjection(orderedAt, SortDirection.Desc),
                new OrderItemProjection(new FieldUuid("orders", "id")),
            ]
        );

        Assert.Equal("user_id", Assert.Single(query.DistinctBy!));
        OrderItemProjection latest = query.OrderBy!.First();
        Assert.Equal(SortDirection.Desc, latest.Direction);
        Assert.Same(orderedAt, latest.Expression.Value);
        OrderItemProjection byId = query.OrderBy!.Last();
        Assert.Equal(SortDirection.Asc, byId.Direction);
        Assert.Equal("id", Assert.IsType<FieldUuid>(byId.Expression.Value).Field);
    }

    [Fact]
    public void LeftJoinWithNullableColumns()
    {
        // samples/32_left_join_nullable.json
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
        // samples/39_aggregates_over_all_rows.json
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
        // samples/45_having.json
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
        // samples/54_in_subquery.json
        Subquery vipUsers = new Subquery(
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

        Subquery subquery = Assert.Single(query.Subqueries!);
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
            [new OrderItemProjection(new FieldString("users", "name"))]
        );

        Assert.Equal(
            "skip",
            Assert.IsType<ParamInteger>(query.Pagination.Skip.Value).Param
        );
        Assert.Equal(20L, query.Pagination.Take.Value);
        _ = Assert.Single(query.OrderBy);
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
