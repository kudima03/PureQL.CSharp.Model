using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record InUuidProjection
{
    public InUuidProjection(UuidNullableProjection value, ListUuid list)
    {
        Value = value;
        List = list;
    }

    public UuidNullableProjection Value { get; }

    public ListUuid List { get; }
}
