using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>integerDivide.integer.nullable@projection</c>.</summary>
public sealed record IntegerDivideIntegerNullableProjection : IOperator
{
    public IntegerDivideIntegerNullableProjection(
        DecimalNullableProjection left,
        DecimalNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableProjection Left { get; }

    public DecimalNullableProjection Right { get; }

    public IType Type => new TypeIntegerNullable();
}
