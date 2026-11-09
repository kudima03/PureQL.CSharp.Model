using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>lessThan.decimal@projection</c>.</summary>
public sealed record LessThanDecimalProjection : IOperator
{
    public LessThanDecimalProjection(
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
