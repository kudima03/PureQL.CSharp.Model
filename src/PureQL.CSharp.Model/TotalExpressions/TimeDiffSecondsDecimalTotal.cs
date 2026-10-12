using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record TimeDiffSecondsDecimalTotal : IOperator
{
    public TimeDiffSecondsDecimalTotal(TimeTotal left, TimeTotal right)
    {
        Left = left;
        Right = right;
    }

    public TimeTotal Left { get; }

    public TimeTotal Right { get; }

    public IType Type => new TypeDecimal();
}
