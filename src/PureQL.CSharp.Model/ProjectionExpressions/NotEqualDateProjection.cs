using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>notEqual.date@projection</c>.</summary>
public sealed record NotEqualDateProjection : IOperator
{
    public NotEqualDateProjection(
        DateNullableProjection left,
        DateNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DateNullableProjection Left { get; }

    public DateNullableProjection Right { get; }

    public IType Type => new TypeBoolean();
}
