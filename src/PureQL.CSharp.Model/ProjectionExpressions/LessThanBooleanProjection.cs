using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record LessThanBooleanProjection : IOperator
{
    public LessThanBooleanProjection(
        BooleanNullableProjection left,
        BooleanNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableProjection Left { get; }

    public BooleanNullableProjection Right { get; }

    public IType Type => new TypeBoolean();
}
