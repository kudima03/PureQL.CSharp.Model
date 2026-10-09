namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceDecimalProjection
{
    public CoalesceDecimalProjection(IEnumerable<DecimalNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableProjection> Values { get; }
}
