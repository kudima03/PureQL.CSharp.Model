using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfMonth.datetime@total</c>.</summary>
public sealed record StartOfMonthDatetimeTotal : IOperator
{
    public StartOfMonthDatetimeTotal(DatetimeTotal operand, StringTotal? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeTotal Operand { get; }

    public StringTotal? Zone { get; }

    public IType Type => new TypeDatetime();
}
