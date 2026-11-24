using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>truncate.decimal.nullable@projection</c>.</summary>
public sealed record TruncateDecimalNullableProjection : IOperator
{
    public TruncateDecimalNullableProjection(
        DecimalOrDecimalNullableProjection operand,
        IntegerNullableProjection digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public DecimalOrDecimalNullableProjection Operand { get; }

    public IntegerNullableProjection Digits { get; }

    public IType Type => new TypeDecimalNullable();
}
