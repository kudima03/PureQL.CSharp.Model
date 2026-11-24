using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>week.date.integer@projection</c>.</summary>
public sealed record WeekDateIntegerProjection : IOperator
{
    public WeekDateIntegerProjection(DateProjection operand)
    {
        Operand = operand;
    }

    public DateProjection Operand { get; }

    public IType Type => new TypeInteger();
}
