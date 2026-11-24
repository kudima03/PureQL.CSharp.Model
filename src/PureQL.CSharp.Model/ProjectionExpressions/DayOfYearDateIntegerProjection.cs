using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>dayOfYear.date.integer@projection</c>.</summary>
public sealed record DayOfYearDateIntegerProjection : IOperator
{
    public DayOfYearDateIntegerProjection(DateProjection operand)
    {
        Operand = operand;
    }

    public DateProjection Operand { get; }

    public IType Type => new TypeInteger();
}
