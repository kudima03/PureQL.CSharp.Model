using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>quarter.date.integer@projection</c>.</summary>
public sealed record QuarterDateIntegerProjection : IOperator
{
    public QuarterDateIntegerProjection(DateProjection operand)
    {
        Operand = operand;
    }

    public DateProjection Operand { get; }

    public IType Type => new TypeInteger();
}
