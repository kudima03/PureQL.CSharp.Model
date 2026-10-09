using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record InDatetimeGroup
{
    public InDatetimeGroup(DatetimeNullableGroup value, ListDatetime list)
    {
        Value = value;
        List = list;
    }

    public DatetimeNullableGroup Value { get; }

    public ListDatetime List { get; }
}
