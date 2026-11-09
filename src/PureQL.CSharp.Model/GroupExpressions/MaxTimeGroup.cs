using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>max.time@group</c>.</summary>
public sealed record MaxTimeGroup : IOperator
{
    public MaxTimeGroup(TimeRow selector, AggregateOver over = AggregateOver.Group)
    {
        Over = over;
        Selector = selector;
    }

    public AggregateOver Over { get; }

    public TimeRow Selector { get; }

    public IType Type => new TypeTime();
}
