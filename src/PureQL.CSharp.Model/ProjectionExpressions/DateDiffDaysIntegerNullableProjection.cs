using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>dateDiffDays.integer.nullable@projection</c>.</summary>
public sealed record DateDiffDaysIntegerNullableProjection : IOperator
{
    public DateDiffDaysIntegerNullableProjection(
        DateNullableProjection left,
        DateNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DateNullableProjection Left { get; }

    public DateNullableProjection Right { get; }

    public IType Type => new TypeIntegerNullable();
}
