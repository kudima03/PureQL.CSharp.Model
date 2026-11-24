using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>day.date.integer@total</c>.</summary>
public sealed record DayDateIntegerTotal : IOperator
{
    public DayDateIntegerTotal(DateTotal operand)
    {
        Operand = operand;
    }

    public DateTotal Operand { get; }

    public IType Type => new TypeInteger();
}
