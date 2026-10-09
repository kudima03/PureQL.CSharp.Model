namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AddDecimalProjection
{
    public AddDecimalProjection(IEnumerable<DecimalProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalProjection> Values { get; }
}
