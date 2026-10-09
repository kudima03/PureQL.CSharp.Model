using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MaxIntegerGroup
{
    public MaxIntegerGroup(IntegerRow selector)
    {
        Selector = selector;
    }

    public IntegerRow Selector { get; }
}
