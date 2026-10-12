using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record GreaterThanTimeProjection : IOperator
{
    public GreaterThanTimeProjection(
        TimeNullableProjection left,
        TimeNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public TimeNullableProjection Left { get; }

    public TimeNullableProjection Right { get; }

    public IType Type => new TypeBoolean();
}
