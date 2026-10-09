namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceUuidProjection
{
    public CoalesceUuidProjection(IEnumerable<UuidNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableProjection> Values { get; }
}
