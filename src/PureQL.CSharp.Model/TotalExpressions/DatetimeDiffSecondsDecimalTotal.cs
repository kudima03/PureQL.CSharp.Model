using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

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
