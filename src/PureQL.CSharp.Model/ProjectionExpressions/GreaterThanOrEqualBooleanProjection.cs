using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greaterThanOrEqual.boolean@projection</c>.</summary>
public sealed record GreaterThanOrEqualBooleanProjection : IOperator
{
    public GreaterThanOrEqualBooleanProjection(
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
