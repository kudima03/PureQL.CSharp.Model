using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>nullIfEqual.integer.nullable@projection</c>.</summary>
public sealed record NullIfEqualIntegerNullableProjection : IOperator
{
    public NullIfEqualIntegerNullableProjection(
        IntegerNullableProjection left,
        DecimalNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableProjection Left { get; }

    public DecimalNullableProjection Right { get; }

    public IType Type => new TypeIntegerNullable();
}
