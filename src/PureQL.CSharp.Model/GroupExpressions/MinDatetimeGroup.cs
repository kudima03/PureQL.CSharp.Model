using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MinDatetimeGroup
{
    public MinDatetimeGroup(DatetimeRow selector)
    {
        Selector = selector;
    }

    public DatetimeRow Selector { get; }
}
