using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>mode.integer@group</c>.</summary>
public sealed record ModeIntegerGroup : IOperator
{
    public ModeIntegerGroup(IntegerRow selector, AggregateOver over = AggregateOver.Group)
    {
        Over = over;
        Selector = selector;
    }

    public AggregateOver Over { get; }

    public IntegerRow Selector { get; }

    public IType Type => new TypeInteger();
}
