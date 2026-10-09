namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record SubtractDecimalProjection
{
    public SubtractDecimalProjection(IEnumerable<DecimalProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalProjection> Values { get; }
}
