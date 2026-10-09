namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceDecimalNullableProjection
{
    public CoalesceDecimalNullableProjection(
        IEnumerable<DecimalNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableProjection> Values { get; }
}
