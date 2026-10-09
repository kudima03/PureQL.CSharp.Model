using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MinStringGroup
{
    public MinStringGroup(StringRow selector)
    {
        Selector = selector;
    }

    public StringRow Selector { get; }
}
