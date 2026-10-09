namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceStringProjection
{
    public CoalesceStringProjection(IEnumerable<StringNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableProjection> Values { get; }
}
