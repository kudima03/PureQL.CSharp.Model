using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record InDateGroup
{
    public InDateGroup(DateNullableGroup value, ListDate list)
    {
        Value = value;
        List = list;
    }

    public DateNullableGroup Value { get; }

    public ListDate List { get; }
}
