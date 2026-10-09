namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record RoundIntegerNullableGroup
{
    public RoundIntegerNullableGroup(DecimalNullableGroup value)
    {
        Value = value;
    }

    public DecimalNullableGroup Value { get; }
}
