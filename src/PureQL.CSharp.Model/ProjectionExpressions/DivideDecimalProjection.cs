namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DivideDecimalProjection
{
    public DivideDecimalProjection(IEnumerable<DecimalProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalProjection> Values { get; }
}
