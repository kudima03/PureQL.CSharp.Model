namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceIntegerProjection
{
    public CoalesceIntegerProjection(IEnumerable<IntegerNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableProjection> Values { get; }
}
