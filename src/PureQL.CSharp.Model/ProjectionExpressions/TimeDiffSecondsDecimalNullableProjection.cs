using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>timeDiffSeconds.decimal.nullable@projection</c>.</summary>
public sealed record TimeDiffSecondsDecimalNullableProjection : IOperator
{
    public TimeDiffSecondsDecimalNullableProjection(
        TimeNullableProjection left,
        TimeNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public TimeNullableProjection Left { get; }

    public TimeNullableProjection Right { get; }

    public IType Type => new TypeDecimalNullable();
}
