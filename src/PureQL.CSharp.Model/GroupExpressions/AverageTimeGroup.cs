using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AverageTimeGroup
{
    public AverageTimeGroup(TimeRow selector)
    {
        Selector = selector;
    }

    public TimeRow Selector { get; }
}
