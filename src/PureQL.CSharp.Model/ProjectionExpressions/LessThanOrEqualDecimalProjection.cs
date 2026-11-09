using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>lessThanOrEqual.decimal@projection</c>.</summary>
public sealed record LessThanOrEqualDecimalProjection : IOperator
{
    public LessThanOrEqualDecimalProjection(
        DecimalNullableProjection left,
        DecimalNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableProjection Left { get; }

    public DecimalNullableProjection Right { get; }

    public IType Type => new TypeBoolean();
}
