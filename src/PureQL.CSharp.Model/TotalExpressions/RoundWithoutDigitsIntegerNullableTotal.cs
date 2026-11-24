using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>round.withoutDigits.integer.nullable@total</c>.</summary>
public sealed record RoundWithoutDigitsIntegerNullableTotal : IOperator
{
    public RoundWithoutDigitsIntegerNullableTotal(
        DeclaresDecimalNullableTotal operand,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Mode = mode;
    }

    public DeclaresDecimalNullableTotal Operand { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeIntegerNullable();
}
