namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record RoundDecimalDigitsNullableProjection
{
    public RoundDecimalDigitsNullableProjection(
        DecimalNullableProjection value,
        IntegerProjection digits
    )
    {
        Value = value;
        Digits = digits;
    }

    public DecimalNullableProjection Value { get; }

    public IntegerProjection Digits { get; }
}
