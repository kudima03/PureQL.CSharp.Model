using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AverageTimeGroup : IOperator
{
    public AverageTimeGroup(TimeRow selector, AggregateOver over = AggregateOver.Group)
    {
        Selector = selector;
        Over = over;
    }

    public TimeRow Selector { get; }

    public AggregateOver Over { get; }

    public IType Type => new TypeTime();
}
