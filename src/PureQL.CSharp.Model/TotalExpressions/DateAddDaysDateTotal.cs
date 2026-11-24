using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>dateAddDays.date@total</c>.</summary>
public sealed record DateAddDaysDateTotal : IOperator
{
    public DateAddDaysDateTotal(DateTotal operand, IntegerTotal days)
    {
        Operand = operand;
        Days = days;
    }

    public DateTotal Operand { get; }

    public IntegerTotal Days { get; }

    public IType Type => new TypeDate();
}
