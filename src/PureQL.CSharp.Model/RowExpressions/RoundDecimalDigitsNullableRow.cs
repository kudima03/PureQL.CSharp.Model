namespace PureQL.CSharp.Model.RowExpressions;

public sealed record RoundDecimalDigitsNullableRow
{
    public RoundDecimalDigitsNullableRow(DecimalNullableRow value, IntegerRow digits)
    {
        Value = value;
        Digits = digits;
    }

    public DecimalNullableRow Value { get; }

    public IntegerRow Digits { get; }
}
