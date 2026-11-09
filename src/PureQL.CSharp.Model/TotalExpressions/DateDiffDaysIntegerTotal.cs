using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>dateDiffDays.integer@total</c>.</summary>
public sealed record DateDiffDaysIntegerTotal : IOperator
{
    public DateDiffDaysIntegerTotal(DateTotal left, DateTotal right)
    {
        Left = left;
        Right = right;
    }

    public DateTotal Left { get; }

    public DateTotal Right { get; }

    public IType Type => new TypeInteger();
}
