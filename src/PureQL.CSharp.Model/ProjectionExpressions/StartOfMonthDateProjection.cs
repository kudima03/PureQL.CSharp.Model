using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfMonth.date@projection</c>.</summary>
public sealed record StartOfMonthDateProjection : IOperator
{
    public StartOfMonthDateProjection(DateProjection operand)
    {
        Operand = operand;
    }

    public DateProjection Operand { get; }

    public IType Type => new TypeDate();
}
