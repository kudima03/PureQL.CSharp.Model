using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>year.date.integer@total</c>.</summary>
public sealed record YearDateIntegerTotal : IOperator
{
    public YearDateIntegerTotal(DateTotal operand)
    {
        Operand = operand;
    }

    public DateTotal Operand { get; }

    public IType Type => new TypeInteger();
}
