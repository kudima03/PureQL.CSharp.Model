using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>max.integer@group</c>.</summary>
public sealed record MaxIntegerGroup : IOperator
{
    public MaxIntegerGroup(IntegerRow selector, AggregateOver over = AggregateOver.Group)
    {
        Over = over;
        Selector = selector;
    }

    public AggregateOver Over { get; }

    public IntegerRow Selector { get; }

    public IType Type => new TypeInteger();
}
