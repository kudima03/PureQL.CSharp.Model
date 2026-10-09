using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MaxDatetimeGroup
{
    public MaxDatetimeGroup(DatetimeRow selector)
    {
        Selector = selector;
    }

    public DatetimeRow Selector { get; }
}
