using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfMonth.date@total</c>.</summary>
public sealed record StartOfMonthDateTotal : IOperator
{
    public StartOfMonthDateTotal(DateTotal operand)
    {
        Operand = operand;
    }

    public DateTotal Operand { get; }

    public IType Type => new TypeDate();
}
