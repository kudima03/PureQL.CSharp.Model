namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record RoundDecimalDigitsGroup
{
    public RoundDecimalDigitsGroup(DecimalGroup value, IntegerGroup digits)
    {
        Value = value;
        Digits = digits;
    }

    public DecimalGroup Value { get; }

    public IntegerGroup Digits { get; }
}
