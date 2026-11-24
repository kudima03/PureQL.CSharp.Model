using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>quarter.date.integer@total</c>.</summary>
public sealed record QuarterDateIntegerTotal : IOperator
{
    public QuarterDateIntegerTotal(DateTotal operand)
    {
        Operand = operand;
    }

    public DateTotal Operand { get; }

    public IType Type => new TypeInteger();
}
