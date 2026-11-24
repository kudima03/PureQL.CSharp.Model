using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>month.datetime.integer@total</c>.</summary>
public sealed record MonthDatetimeIntegerTotal : IOperator
{
    public MonthDatetimeIntegerTotal(DatetimeTotal operand, StringTotal? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeTotal Operand { get; }

    public StringTotal? Zone { get; }

    public IType Type => new TypeInteger();
}
