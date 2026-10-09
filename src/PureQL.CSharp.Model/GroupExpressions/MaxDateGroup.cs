using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MaxDateGroup
{
    public MaxDateGroup(DateRow selector)
    {
        Selector = selector;
    }

    public DateRow Selector { get; }
}
