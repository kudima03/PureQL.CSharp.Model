using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>max.string.nullable@group</c>.</summary>
public sealed record MaxStringNullableGroup : IOperator
{
    public MaxStringNullableGroup(
        StringNullableRow selector,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Predicate = predicate;
        Over = over;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }

    public StringNullableRow Selector { get; }

    public IType Type => new TypeStringNullable();
}
