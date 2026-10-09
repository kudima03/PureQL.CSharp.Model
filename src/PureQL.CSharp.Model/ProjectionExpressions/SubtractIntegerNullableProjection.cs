namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record SubtractIntegerNullableProjection
{
    public SubtractIntegerNullableProjection(
        IEnumerable<IntegerNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableProjection> Values { get; }
}
