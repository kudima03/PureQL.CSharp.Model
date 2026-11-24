using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>round.decimal@projection</c>.</summary>
public sealed record RoundDecimalProjection : IOperator
{
    public RoundDecimalProjection(
        DeclaresDecimalProjection operand,
        IntegerProjection digits,
        RoundingMode mode = RoundingMode.HalfAwayFromZero
    )
    {
        Operand = operand;
        Digits = digits;
        Mode = mode;
    }

    public DeclaresDecimalProjection Operand { get; }

    public IntegerProjection Digits { get; }

    public RoundingMode Mode { get; }

    public IType Type => new TypeDecimal();
}
