using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record InTimeGroup
{
    public InTimeGroup(TimeNullableGroup value, ListTime list)
    {
        Value = value;
        List = list;
    }

    public TimeNullableGroup Value { get; }

    public ListTime List { get; }
}
