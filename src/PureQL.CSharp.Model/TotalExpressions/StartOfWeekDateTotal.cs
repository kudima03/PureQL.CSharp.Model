using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfWeek.date@total</c>.</summary>
public sealed record StartOfWeekDateTotal : IOperator
{
    public StartOfWeekDateTotal(DateTotal operand)
    {
        Operand = operand;
    }

    public DateTotal Operand { get; }

    public IType Type => new TypeDate();
}
