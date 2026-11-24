using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>power.decimal.nullable@projection</c>.</summary>
public sealed record PowerDecimalNullableProjection : IOperator
{
    public PowerDecimalNullableProjection(
        DecimalNullableProjection operand,
        DecimalNullableProjection exponent
    )
    {
        Operand = operand;
        Exponent = exponent;
    }

    public DecimalNullableProjection Operand { get; }

    public DecimalNullableProjection Exponent { get; }

    public IType Type => new TypeDecimalNullable();
}
