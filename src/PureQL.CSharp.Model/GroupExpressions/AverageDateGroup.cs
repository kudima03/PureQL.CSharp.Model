using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AverageDateGroup
{
    public AverageDateGroup(DateRow selector)
    {
        Selector = selector;
    }

    public DateRow Selector { get; }
}
