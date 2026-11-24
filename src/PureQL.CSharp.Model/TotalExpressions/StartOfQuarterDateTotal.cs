using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfQuarter.date@total</c>.</summary>
public sealed record StartOfQuarterDateTotal : IOperator
{
    public StartOfQuarterDateTotal(DateTotal operand)
    {
        Operand = operand;
    }

    public DateTotal Operand { get; }

    public IType Type => new TypeDate();
}
