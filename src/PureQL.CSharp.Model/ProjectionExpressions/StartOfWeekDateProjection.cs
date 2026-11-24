using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfWeek.date@projection</c>.</summary>
public sealed record StartOfWeekDateProjection : IOperator
{
    public StartOfWeekDateProjection(DateProjection operand)
    {
        Operand = operand;
    }

    public DateProjection Operand { get; }

    public IType Type => new TypeDate();
}
