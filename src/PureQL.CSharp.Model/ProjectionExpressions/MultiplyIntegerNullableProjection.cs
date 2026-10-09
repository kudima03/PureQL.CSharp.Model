namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MultiplyIntegerNullableProjection
{
    public MultiplyIntegerNullableProjection(
        IEnumerable<IntegerNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableProjection> Values { get; }
}
