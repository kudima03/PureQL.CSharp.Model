using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>lessThan.time@projection</c>.</summary>
public sealed record LessThanTimeProjection : IOperator
{
    public LessThanTimeProjection(
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
