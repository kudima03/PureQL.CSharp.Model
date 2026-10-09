using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MaxTimeGroup
{
    public MaxTimeGroup(TimeRow selector)
    {
        Selector = selector;
    }

    public TimeRow Selector { get; }
}
