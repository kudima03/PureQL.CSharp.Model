using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>nullIfEqual.decimal.nullable@projection</c>.</summary>
public sealed record NullIfEqualDecimalNullableProjection : IOperator
{
    public NullIfEqualDecimalNullableProjection(
        DecimalOrDecimalNullableProjection left,
        DecimalNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalOrDecimalNullableProjection Left { get; }

    public DecimalNullableProjection Right { get; }

    public IType Type => new TypeDecimalNullable();
}
