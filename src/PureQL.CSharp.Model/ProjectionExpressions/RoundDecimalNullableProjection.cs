using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record RoundDecimalNullableProjection : IOperator
{
    public RoundDecimalNullableProjection(
        DecimalNullableProjection operand,
        IntegerProjection digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public DecimalNullableProjection Operand { get; }

    public IntegerProjection Digits { get; }

    public IType Type => new TypeDecimalNullable();
}
