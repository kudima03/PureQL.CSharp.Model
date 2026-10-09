using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record InUuidGroup
{
    public InUuidGroup(UuidNullableGroup value, ListUuid list)
    {
        Value = value;
        List = list;
    }

    public UuidNullableGroup Value { get; }

    public ListUuid List { get; }
}
