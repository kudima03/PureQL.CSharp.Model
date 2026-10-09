namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CeilingIntegerNullableProjection
{
    public CeilingIntegerNullableProjection(DecimalNullableProjection value)
    {
        Value = value;
    }

    public DecimalNullableProjection Value { get; }
}
