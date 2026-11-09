using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greaterThanOrEqual.datetime@projection</c>.</summary>
public sealed record GreaterThanOrEqualDatetimeProjection : IOperator
{
    public GreaterThanOrEqualDatetimeProjection(
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
