namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MultiplyDecimalProjection
{
    public MultiplyDecimalProjection(IEnumerable<DecimalProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalProjection> Values { get; }
}
