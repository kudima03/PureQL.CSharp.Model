using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>month.date.integer@total</c>.</summary>
public sealed record MonthDateIntegerTotal : IOperator
{
    public MonthDateIntegerTotal(DateTotal operand)
    {
        Operand = operand;
    }

    public DateTotal Operand { get; }

    public IType Type => new TypeInteger();
}
