using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record GreaterThanUuidProjection : IOperator
{
    public GreaterThanUuidProjection(
        UuidNullableProjection left,
        UuidNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public UuidNullableProjection Left { get; }

    public UuidNullableProjection Right { get; }

    public IType Type => new TypeBoolean();
}
