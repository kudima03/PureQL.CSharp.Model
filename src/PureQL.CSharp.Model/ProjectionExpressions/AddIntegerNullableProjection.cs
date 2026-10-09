namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AddIntegerNullableProjection
{
    public AddIntegerNullableProjection(IEnumerable<IntegerNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableProjection> Values { get; }
}
