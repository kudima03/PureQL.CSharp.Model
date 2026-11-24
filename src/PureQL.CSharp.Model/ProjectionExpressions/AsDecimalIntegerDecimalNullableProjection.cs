using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asDecimal.integer.decimal.nullable@projection</c>.</summary>
public sealed record AsDecimalIntegerDecimalNullableProjection : IOperator
{
    public AsDecimalIntegerDecimalNullableProjection(
        DeclaresIntegerNullableProjection operand
    )
    {
        Operand = operand;
    }

    public DeclaresIntegerNullableProjection Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
