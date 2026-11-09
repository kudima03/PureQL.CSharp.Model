using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>lessThanOrEqual.datetime@projection</c>.</summary>
public sealed record LessThanOrEqualDatetimeProjection : IOperator
{
    public LessThanOrEqualDatetimeProjection(
        DatetimeNullableProjection left,
        DatetimeNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableProjection Left { get; }

    public DatetimeNullableProjection Right { get; }

    public IType Type => new TypeBoolean();
}
