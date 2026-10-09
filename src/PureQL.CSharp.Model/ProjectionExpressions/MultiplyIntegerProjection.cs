namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MultiplyIntegerProjection
{
    public MultiplyIntegerProjection(IEnumerable<IntegerProjection> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerProjection> Values { get; }
}
