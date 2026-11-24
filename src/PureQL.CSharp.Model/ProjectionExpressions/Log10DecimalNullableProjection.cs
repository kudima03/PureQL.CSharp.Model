using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>log10.decimal.nullable@projection</c>.</summary>
public sealed record Log10DecimalNullableProjection : IOperator
{
    public Log10DecimalNullableProjection(
        IntegerNullableOrDecimalNullableProjection operand
    )
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableProjection Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
