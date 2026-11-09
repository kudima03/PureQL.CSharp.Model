using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>min.time@group</c>.</summary>
public sealed record MinTimeGroup : IOperator
{
    public MinTimeGroup(TimeRow selector, AggregateOver over = AggregateOver.Group)
    {
        Over = over;
        Selector = selector;
    }

    public AggregateOver Over { get; }

    public TimeRow Selector { get; }

    public IType Type => new TypeTime();
}
