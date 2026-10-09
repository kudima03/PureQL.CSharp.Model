namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record SubtractDecimalNullableProjection
{
    public SubtractDecimalNullableProjection(
        IEnumerable<DecimalNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableProjection> Values { get; }
}
