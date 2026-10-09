namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AddIntegerProjection
{
    public AddIntegerProjection(IEnumerable<IntegerProjection> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerProjection> Values { get; }
}
