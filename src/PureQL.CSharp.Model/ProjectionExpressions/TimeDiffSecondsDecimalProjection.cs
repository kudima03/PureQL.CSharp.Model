using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record TimeDiffSecondsDecimalProjection : IOperator
{
    public TimeDiffSecondsDecimalProjection(TimeProjection left, TimeProjection right)
    {
        Left = left;
        Right = right;
    }

    public TimeProjection Left { get; }

    public TimeProjection Right { get; }

    public IType Type => new TypeDecimal();
}
