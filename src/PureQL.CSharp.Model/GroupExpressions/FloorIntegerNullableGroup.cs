namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record FloorIntegerNullableGroup
{
    public FloorIntegerNullableGroup(DecimalNullableGroup value)
    {
        Value = value;
    }

    public DecimalNullableGroup Value { get; }
}
