using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetimeDiffMonths.integer@total</c>.</summary>
public sealed record DatetimeDiffMonthsIntegerTotal : IOperator
{
    public DatetimeDiffMonthsIntegerTotal(
        DatetimeTotal left,
        DatetimeTotal right,
        StringTotal? zone = null
    )
    {
        Left = left;
        Right = right;
        Zone = zone;
    }

    public DatetimeTotal Left { get; }

    public DatetimeTotal Right { get; }

    public StringTotal? Zone { get; }

    public IType Type => new TypeInteger();
}
