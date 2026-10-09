using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record InDecimalGroup
{
    public InDecimalGroup(DecimalNullableGroup value, ListDecimal list)
    {
        Value = value;
        List = list;
    }

    public DecimalNullableGroup Value { get; }

    public ListDecimal List { get; }
}
