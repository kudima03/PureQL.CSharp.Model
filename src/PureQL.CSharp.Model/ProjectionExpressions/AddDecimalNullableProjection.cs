namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AddDecimalNullableProjection
{
    public AddDecimalNullableProjection(IEnumerable<DecimalNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableProjection> Values { get; }
}
