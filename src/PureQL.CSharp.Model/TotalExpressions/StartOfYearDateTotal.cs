using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfYear.date@total</c>.</summary>
public sealed record StartOfYearDateTotal : IOperator
{
    public StartOfYearDateTotal(DateTotal operand)
    {
        Operand = operand;
    }

    public DateTotal Operand { get; }

    public IType Type => new TypeDate();
}
