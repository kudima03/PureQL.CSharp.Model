using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.GroupExpressions;
using PureQL.CSharp.Model.GroupKeys;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.ProjectionExpressions;
using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.SelectItems;

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
        Assert.False(plain.Distinct);
    }

    [Fact]
    public void GroupByCountWithHaving()
    {
        // samples/44_having.json
        DecimalNullableGroup count = new DecimalNullableGroup(
            new AggregateDecimalNullableGroup(new CountGroup())
        );
        MainGroupedQuery query = new MainGroupedQuery(
            Entity("orders"),
            [
                new GroupKey(
                    new GroupKeyNonNullable(
                        new GroupKeyUuid(new UuidRow(new FieldUuid("orders", "user_id")))
                    )
                ),
            ],
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
                            count,
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
        );

        GroupKeyUuid key = Assert.Single(query.GroupBy).AsT0.AsT7;
        Assert.Null(key.Alias);
        Assert.Equal("uuid", key.Type.Name);
        Assert.Equal("user_id", key.Expression.AsT0.Field);

        Assert.Equal(2, query.Select.Count());
        Assert.Equal(0, query.Select.First().AsT0.AsT7.Expression.AsT0.Key);
        CountGroup selectedCount = query.Select.Last().AsT0.AsT0.Expression.AsT7.AsT0;
        Assert.Null(selectedCount.Predicate);
        Assert.Equal(AggregateOver.Group, selectedCount.Over);

        GreaterThanOrEqualDecimalGroup having = query.Having!.AsT4.AsT5.AsT0;
        Assert.Same(count, having.Left);
        Assert.Equal(5, having.Right.AsT2.AsT2.Value);
    }

    [Fact]
    public void InSubquery()
    {
        // samples/53_in_subquery.json
        Subquery vipUsers = new Subquery(
            "vip_users",
            new Query(
                new PlainQuery(
                    Entity("users"),
                    [Column("id", new UuidProjection(new FieldUuid("users", "id")))],
                    joins: null,
                    where: new BooleanRow(
                        new ComparisonRow(
                            new EqualRow(
                                new EqualStringRow(
                                    new StringNullableRow(
                                        new FieldAsStringNullable(
                                            new FieldString("users", "tier")
                                        )
                                    ),
                                    new StringNullableRow(
                                        new LiteralAsStringNullable(
                                            new LiteralString("vip")
                                        )
                                    )
                                )
                            )
                        )
                    ),
                    orderBy: null,
                    pagination: null,
                    distinct: false
                )
            )
        );
        MainPlainQuery query = new MainPlainQuery(
            Entity("orders"),
            [Column("id", new UuidProjection(new FieldUuid("orders", "id")))],
            subqueries: [vipUsers],
            joins: null,
            where: new BooleanRow(
                new ComparisonRow(
                    new InRow(
                        new InUuidRow(
                            new UuidNullableRow(
                                new FieldAsUuidNullable(
                                    new FieldUuid("orders", "user_id")
                                )
                            ),
                            new ListUuid(new ListSubqueryColumnUuid("vip_users", "id"))
                        )
                    )
                )
            ),
            orderBy: null,
            pagination: null,
            distinct: false
        );

        Subquery subquery = Assert.Single(query.Subqueries!);
        Assert.Equal("vip_users", subquery.Name);
        Assert.True(subquery.Query.IsT1);
        EqualStringRow tier = subquery.Query.AsT1.Where!.AsT4.AsT0.AsT1;
        Assert.Equal("vip", tier.Right.AsT2.AsT0.Value);

        ListSubqueryColumnUuid column = query.Where!.AsT4.AsT2.AsT6.List.AsT2;
        Assert.Equal("vip_users", column.Subquery);
        Assert.Equal("id", column.Field);
        Assert.False(column.Nullable);
        Assert.Equal("uuid", column.Type.Name);
    }

    [Fact]
    public void LeftJoinWithNullableColumns()
    {
        // samples/31_left_join_nullable.json
        FieldUuidNullable couponId = new FieldUuidNullable("orders", "coupon_id");
        MainPlainQuery query = new MainPlainQuery(
            Entity("orders"),
            [
                Column(
                    "coupon_code",
                    new StringProjection(
                        new ConditionalStringProjection(
                            new CoalesceStringProjection([
                                new StringNullableProjection(
                                    new FieldAsStringNullable(
                                        new FieldStringNullable("coupons", "code")
                                    )
                                ),
                                new StringNullableProjection(
                                    new LiteralAsStringNullable(new LiteralString("none"))
                                ),
                            ])
                        )
                    )
                ),
                new SelectItemProjection(
                    new SelectItemProjectionNullable(
                        new SelectItemProjectionDecimalNullable(
                            "total_after_discount",
                            new DecimalNullableProjection(
                                new ArithmeticDecimalNullableProjection(
                                    new SubtractDecimalNullableProjection([
                                        new DecimalNullableProjection(
                                            new FieldAsDecimalNullable(
                                                new FieldDecimal("orders", "total")
                                            )
                                        ),
                                        new DecimalNullableProjection(
                                            new FieldAsDecimalNullable(
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
                        JoinType.Left,
                        "coupons",
                        new BooleanRow(
                            new ComparisonRow(
                                new EqualRow(
                                    new EqualUuidRow(
                                        new UuidNullableRow(
                                            new FieldAsUuidNullable(couponId)
                                        ),
                                        new UuidNullableRow(
                                            new FieldAsUuidNullable(
                                                new FieldUuid("coupons", "id")
                                            )
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
                                            new FieldAsUuidNullable(couponId)
                                        ),
                                        new UuidNullableRow(
                                            new LiteralAsUuidNullable(
                                                new LiteralUuidNullable()
                                            )
                                        )
                                    )
                                )
                            )
                        ),
                    ])
                )
            ),
            orderBy: null,
            pagination: new Pagination(0, new ParamInteger("page_size")),
            distinct: true
        );

        JoinEntity join = Assert.Single(query.Joins!).AsT0;
        Assert.Equal(JoinType.Left, join.Type);
        Assert.Equal("coupons", join.Entity);
        Assert.Null(join.Alias);

        SelectItemProjectionDecimalNullable total = query.Select.Last().AsT1.AsT1;
        Assert.True(total.Type.Nullable);
        Assert.Equal("decimal", total.Type.Name);
        Assert.Equal(2, total.Expression.AsT3.AsT1.Values.Count());

        EqualUuidRow isNull = Assert
            .Single(query.Where!.AsT3.AsT1.Conditions)
            .AsT4.AsT0.AsT6;
        Assert.Same(couponId, isNull.Left.AsT0.AsT1);
        Assert.True(isNull.Right.AsT2.AsT1.Type.Nullable);

        Assert.Equal(0L, query.Pagination!.Skip.AsT0);
        Assert.Equal("page_size", query.Pagination.Take.AsT1.Name);
        Assert.True(query.Distinct);
    }
}
