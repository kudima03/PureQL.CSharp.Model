using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MinIntegerGroup
{
    public MinIntegerGroup(IntegerRow selector)
    {
        Selector = selector;
    }

    public IntegerRow Selector { get; }
}
