using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MinDecimalGroup
{
    public MinDecimalGroup(DecimalRow selector)
    {
        Selector = selector;
    }

    public DecimalRow Selector { get; }
}
