using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>dayOfWeek.date.integer@projection</c>.</summary>
public sealed record DayOfWeekDateIntegerProjection : IOperator
{
    public DayOfWeekDateIntegerProjection(DateProjection operand)
    {
        Operand = operand;
    }

    public DateProjection Operand { get; }

    public IType Type => new TypeInteger();
}
