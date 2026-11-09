using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime@total</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeTotal : IOperator
{
    public DatetimeAddSecondsDatetimeTotal(DatetimeTotal left, DecimalTotal right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeTotal Left { get; }

    public DecimalTotal Right { get; }

    public IType Type => new TypeDatetime();
}
