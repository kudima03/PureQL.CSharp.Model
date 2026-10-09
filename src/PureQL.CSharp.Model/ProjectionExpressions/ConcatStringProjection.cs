namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record ConcatStringProjection
{
    public ConcatStringProjection(IEnumerable<StringProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringProjection> Values { get; }
}
