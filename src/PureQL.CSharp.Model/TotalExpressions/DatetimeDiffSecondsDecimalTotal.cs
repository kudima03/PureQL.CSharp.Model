using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetimeDiffSeconds.decimal@total</c>.</summary>
public sealed record DatetimeDiffSecondsDecimalTotal : IOperator
{
    public DatetimeDiffSecondsDecimalTotal(DatetimeTotal left, DatetimeTotal right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeTotal Left { get; }

    public DatetimeTotal Right { get; }

    public IType Type => new TypeDecimal();
}
