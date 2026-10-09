using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record InBooleanGroup
{
    public InBooleanGroup(BooleanNullableGroup value, ListBoolean list)
    {
        Value = value;
        List = list;
    }

    public BooleanNullableGroup Value { get; }

    public ListBoolean List { get; }
}
