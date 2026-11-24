using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime@total</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeTotal : IOperator
{
    public DatetimeAddSecondsDatetimeTotal(DatetimeTotal operand, DecimalTotal seconds)
    {
        Operand = operand;
        Seconds = seconds;
    }

    public DatetimeTotal Operand { get; }

    public DecimalTotal Seconds { get; }

    public IType Type => new TypeDatetime();
}
