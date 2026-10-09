using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MaxStringGroup
{
    public MaxStringGroup(StringRow selector)
    {
        Selector = selector;
    }

    public StringRow Selector { get; }
}
