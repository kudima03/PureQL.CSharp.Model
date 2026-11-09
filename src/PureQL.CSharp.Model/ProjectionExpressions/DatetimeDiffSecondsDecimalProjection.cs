using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetimeDiffSeconds.decimal@projection</c>.</summary>
public sealed record DatetimeDiffSecondsDecimalProjection : IOperator
{
    public DatetimeDiffSecondsDecimalProjection(
        DatetimeProjection left,
        DatetimeProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeProjection Left { get; }

    public DatetimeProjection Right { get; }

    public IType Type => new TypeDecimal();
}
