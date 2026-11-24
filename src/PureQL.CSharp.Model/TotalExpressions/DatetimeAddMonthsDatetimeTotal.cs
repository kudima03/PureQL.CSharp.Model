using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetimeAddMonths.datetime@total</c>.</summary>
public sealed record DatetimeAddMonthsDatetimeTotal : IOperator
{
    public DatetimeAddMonthsDatetimeTotal(
        DatetimeTotal operand,
        IntegerTotal months,
        StringTotal? zone = null
    )
    {
        Operand = operand;
        Months = months;
        Zone = zone;
    }

    public DatetimeTotal Operand { get; }

    public IntegerTotal Months { get; }

    public StringTotal? Zone { get; }

    public IType Type => new TypeDatetime();
}
