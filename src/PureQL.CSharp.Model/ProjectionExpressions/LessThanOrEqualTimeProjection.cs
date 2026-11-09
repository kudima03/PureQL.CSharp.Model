using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>lessThanOrEqual.time@projection</c>.</summary>
public sealed record LessThanOrEqualTimeProjection : IOperator
{
    public LessThanOrEqualTimeProjection(
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
