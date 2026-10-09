using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MinTimeGroup
{
    public MinTimeGroup(TimeRow selector)
    {
        Selector = selector;
    }

    public TimeRow Selector { get; }
}
