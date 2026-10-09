namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceTimeNullableProjection
{
    public CoalesceTimeNullableProjection(IEnumerable<TimeNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableProjection> Values { get; }
}
