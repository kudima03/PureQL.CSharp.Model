using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>last.date.nullable@total</c>.</summary>
public sealed record LastDateNullableTotal : IOperator
{
    public LastDateNullableTotal(
        DateNullableRow selector,
        IEnumerable<OrderItemRow> orderBy,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
        OrderBy = orderBy;
    }

    public BooleanRow? Predicate { get; }

    public DateNullableRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeDateNullable();
}
