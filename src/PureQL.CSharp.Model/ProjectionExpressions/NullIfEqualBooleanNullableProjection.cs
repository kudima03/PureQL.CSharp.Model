using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>nullIfEqual.boolean.nullable@projection</c>.</summary>
public sealed record NullIfEqualBooleanNullableProjection : IOperator
{
    public NullIfEqualBooleanNullableProjection(
        BooleanNullableProjection left,
        BooleanNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableProjection Left { get; }

    public BooleanNullableProjection Right { get; }

    public IType Type => new TypeBooleanNullable();
}
