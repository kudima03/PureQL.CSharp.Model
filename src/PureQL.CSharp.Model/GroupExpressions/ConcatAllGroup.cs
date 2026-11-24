using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>concatAll@group</c>.</summary>
public sealed record ConcatAllGroup : IOperator
{
    public ConcatAllGroup(
        StringNullableRow selector,
        Separator separator,
        IEnumerable<OrderItemRow> orderBy,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group,
        bool distinct = false
    )
    {
        Predicate = predicate;
        Over = over;
        Selector = selector;
        Separator = separator;
        OrderBy = orderBy;
        Distinct = distinct;
    }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }

    public StringNullableRow Selector { get; }

    public Separator Separator { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public bool Distinct { get; }

    public IType Type => new TypeString();
}
