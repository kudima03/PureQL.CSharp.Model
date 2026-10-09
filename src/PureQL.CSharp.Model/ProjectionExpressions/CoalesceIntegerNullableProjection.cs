namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceIntegerNullableProjection
{
    public CoalesceIntegerNullableProjection(
        IEnumerable<IntegerNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableProjection> Values { get; }
}
