namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record SubtractIntegerProjection
{
    public SubtractIntegerProjection(IEnumerable<IntegerProjection> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerProjection> Values { get; }
}
