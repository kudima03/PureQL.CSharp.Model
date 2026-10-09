using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AverageDatetimeGroup
{
    public AverageDatetimeGroup(DatetimeRow selector)
    {
        Selector = selector;
    }

    public DatetimeRow Selector { get; }
}
