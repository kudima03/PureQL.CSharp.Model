using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>first.datetime.nullable@total</c>.</summary>
public sealed record FirstDatetimeNullableTotal : IOperator
{
    public FirstDatetimeNullableTotal(
        DatetimeNullableRow selector,
        IEnumerable<OrderItemRow> orderBy,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
        OrderBy = orderBy;
    }

    public BooleanRow? Predicate { get; }

    public DatetimeNullableRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeDatetimeNullable();
}
