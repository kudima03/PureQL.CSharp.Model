using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>round.withoutDigits.integer@projection</c>.</summary>
public sealed record RoundWithoutDigitsIntegerProjection : IOperator
{
    public RoundWithoutDigitsIntegerProjection(
        DeclaresDecimalProjection operand,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Mode = mode;
    }

    public DeclaresDecimalProjection Operand { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeInteger();
}
