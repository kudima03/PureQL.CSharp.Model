namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceUuidNullableProjection
{
    public CoalesceUuidNullableProjection(IEnumerable<UuidNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableProjection> Values { get; }
}
