namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DivideDecimalNullableProjection
{
    public DivideDecimalNullableProjection(IEnumerable<DecimalNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableProjection> Values { get; }
}
