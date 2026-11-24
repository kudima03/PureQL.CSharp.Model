using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>weekYear.date.integer@projection</c>.</summary>
public sealed record WeekYearDateIntegerProjection : IOperator
{
    public WeekYearDateIntegerProjection(DateProjection operand)
    {
        Operand = operand;
    }

    public DateProjection Operand { get; }

    public IType Type => new TypeInteger();
}
