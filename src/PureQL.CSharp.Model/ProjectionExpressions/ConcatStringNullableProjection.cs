namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record ConcatStringNullableProjection
{
    public ConcatStringNullableProjection(IEnumerable<StringNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableProjection> Values { get; }
}
