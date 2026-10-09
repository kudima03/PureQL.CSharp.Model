using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record InStringGroup
{
    public InStringGroup(StringNullableGroup value, ListString list)
    {
        Value = value;
        List = list;
    }

    public StringNullableGroup Value { get; }

    public ListString List { get; }
}
