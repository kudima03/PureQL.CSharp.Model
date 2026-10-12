using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DatetimeDiffSecondsDecimalNullableProjection : IOperator
{
    public DatetimeDiffSecondsDecimalNullableProjection(
        DatetimeNullableProjection left,
        DatetimeNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableProjection Left { get; }

    public DatetimeNullableProjection Right { get; }

    public IType Type => new TypeDecimalNullable();
}
