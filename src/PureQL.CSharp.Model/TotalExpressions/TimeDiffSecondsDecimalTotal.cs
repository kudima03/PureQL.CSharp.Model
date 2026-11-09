using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>timeDiffSeconds.decimal@total</c>.</summary>
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
