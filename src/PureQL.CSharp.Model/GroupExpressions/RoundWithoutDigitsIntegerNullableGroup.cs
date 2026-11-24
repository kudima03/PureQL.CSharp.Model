using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>round.withoutDigits.integer.nullable@group</c>.</summary>
public sealed record RoundWithoutDigitsIntegerNullableGroup : IOperator
{
    public RoundWithoutDigitsIntegerNullableGroup(
        DeclaresDecimalNullableGroup operand,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Mode = mode;
    }

    public DeclaresDecimalNullableGroup Operand { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeIntegerNullable();
}
