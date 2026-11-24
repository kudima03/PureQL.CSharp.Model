using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>weekYear.date.integer@total</c>.</summary>
public sealed record WeekYearDateIntegerTotal : IOperator
{
    public WeekYearDateIntegerTotal(DateTotal operand)
    {
        Operand = operand;
    }

    public DateTotal Operand { get; }

    public IType Type => new TypeInteger();
}
