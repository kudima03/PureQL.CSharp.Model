namespace PureQL.CSharp.Model.RowExpressions;

public sealed record RoundDecimalDigitsRow
{
    public RoundDecimalDigitsRow(DecimalRow value, IntegerRow digits)
    {
        Value = value;
        Digits = digits;
    }

    public DecimalRow Value { get; }

    public IntegerRow Digits { get; }
}
