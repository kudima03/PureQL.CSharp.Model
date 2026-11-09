using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>round.decimal.nullable@projection</c>.</summary>
public sealed record RoundDecimalNullableProjection : IOperator
{
    public RoundDecimalNullableProjection(
        IntegerNullableOrDecimalNullableProjection operand,
        IntegerProjection digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public IntegerNullableOrDecimalNullableProjection Operand { get; }

    public IntegerProjection Digits { get; }

    public IType Type => new TypeDecimalNullable();
}
