using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>round.withoutDigits.integer.nullable@row</c>.</summary>
public sealed record RoundWithoutDigitsIntegerNullableRow : IOperator
{
    public RoundWithoutDigitsIntegerNullableRow(
        DeclaresDecimalNullableRow operand,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Mode = mode;
    }

    public DeclaresDecimalNullableRow Operand { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeIntegerNullable();
}
