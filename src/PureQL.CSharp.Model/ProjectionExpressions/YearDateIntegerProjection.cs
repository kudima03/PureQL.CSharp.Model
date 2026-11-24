using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>year.date.integer@projection</c>.</summary>
public sealed record YearDateIntegerProjection : IOperator
{
    public YearDateIntegerProjection(DateProjection operand)
    {
        Operand = operand;
    }

    public DateProjection Operand { get; }

    public IType Type => new TypeInteger();
}
