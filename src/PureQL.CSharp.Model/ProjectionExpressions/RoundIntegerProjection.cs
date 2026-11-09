using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>round.integer@projection</c>.</summary>
public sealed record RoundIntegerProjection : IOperator
{
    public RoundIntegerProjection(DecimalProjection operand)
    {
        Operand = operand;
    }

    public DecimalProjection Operand { get; }

    public IType Type => new TypeInteger();
}
