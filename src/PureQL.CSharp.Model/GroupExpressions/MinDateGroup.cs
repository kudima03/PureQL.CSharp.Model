using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MinDateGroup
{
    public MinDateGroup(DateRow selector)
    {
        Selector = selector;
    }

    public DateRow Selector { get; }
}
