namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record RoundDecimalDigitsNullableGroup
{
    public RoundDecimalDigitsNullableGroup(
        DecimalNullableGroup value,
        IntegerGroup digits
    )
    {
        Value = value;
        Digits = digits;
    }

    public DecimalNullableGroup Value { get; }

    public IntegerGroup Digits { get; }
}
