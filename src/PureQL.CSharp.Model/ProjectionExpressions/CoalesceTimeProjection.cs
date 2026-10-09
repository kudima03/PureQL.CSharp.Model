namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceTimeProjection
{
    public CoalesceTimeProjection(IEnumerable<TimeNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableProjection> Values { get; }
}
