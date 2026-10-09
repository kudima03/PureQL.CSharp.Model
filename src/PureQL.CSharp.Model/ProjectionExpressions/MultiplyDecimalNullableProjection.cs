namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MultiplyDecimalNullableProjection
{
    public MultiplyDecimalNullableProjection(
        IEnumerable<DecimalNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableProjection> Values { get; }
}
