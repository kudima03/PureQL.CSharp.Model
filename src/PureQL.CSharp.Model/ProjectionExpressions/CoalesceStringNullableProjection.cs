namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceStringNullableProjection
{
    public CoalesceStringNullableProjection(IEnumerable<StringNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableProjection> Values { get; }
}
