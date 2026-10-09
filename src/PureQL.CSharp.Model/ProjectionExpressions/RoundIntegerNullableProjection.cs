namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record RoundIntegerNullableProjection
{
    public RoundIntegerNullableProjection(DecimalNullableProjection value)
    {
        Value = value;
    }

    public DecimalNullableProjection Value { get; }
}
