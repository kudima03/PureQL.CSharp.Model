using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>truncate.withDigits.integer.nullable@projection</c>.</summary>
public sealed record TruncateWithDigitsIntegerNullableProjection : IOperator
{
    public TruncateWithDigitsIntegerNullableProjection(
        IntegerNullableProjection operand,
        IntegerNullableProjection digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public IntegerNullableProjection Operand { get; }

    public IntegerNullableProjection Digits { get; }

    public IType Type => new TypeIntegerNullable();
}
