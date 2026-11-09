using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>timeAddSeconds.time@total</c>.</summary>
public sealed record TimeAddSecondsTimeTotal : IOperator
{
    public TimeAddSecondsTimeTotal(TimeTotal left, DecimalTotal right)
    {
        Left = left;
        Right = right;
    }

    public TimeTotal Left { get; }

    public DecimalTotal Right { get; }

    public IType Type => new TypeTime();
}
