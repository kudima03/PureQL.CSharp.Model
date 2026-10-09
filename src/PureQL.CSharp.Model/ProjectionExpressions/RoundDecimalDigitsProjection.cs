namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record RoundDecimalDigitsProjection
{
    public RoundDecimalDigitsProjection(DecimalProjection value, IntegerProjection digits)
    {
        Value = value;
        Digits = digits;
    }

    public DecimalProjection Value { get; }

    public IntegerProjection Digits { get; }
}
