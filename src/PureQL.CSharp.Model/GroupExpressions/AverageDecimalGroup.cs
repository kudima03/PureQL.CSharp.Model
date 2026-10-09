using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AverageDecimalGroup
{
    public AverageDecimalGroup(DecimalRow selector)
    {
        Selector = selector;
    }

    public DecimalRow Selector { get; }
}
