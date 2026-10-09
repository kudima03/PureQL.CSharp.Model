namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CeilingIntegerNullableGroup
{
    public CeilingIntegerNullableGroup(DecimalNullableGroup value)
    {
        Value = value;
    }

    public DecimalNullableGroup Value { get; }
}
