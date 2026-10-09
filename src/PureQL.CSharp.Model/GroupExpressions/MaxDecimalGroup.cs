using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MaxDecimalGroup
{
    public MaxDecimalGroup(DecimalRow selector)
    {
        Selector = selector;
    }

    public DecimalRow Selector { get; }
}
