using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>dateAddMonths.date@total</c>.</summary>
public sealed record DateAddMonthsDateTotal : IOperator
{
    public DateAddMonthsDateTotal(DateTotal operand, IntegerTotal months)
    {
        Operand = operand;
        Months = months;
    }

    public DateTotal Operand { get; }

    public IntegerTotal Months { get; }

    public IType Type => new TypeDate();
}
