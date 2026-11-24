using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>truncate.withoutDigits.integer.nullable@projection</c>.</summary>
public sealed record TruncateWithoutDigitsIntegerNullableProjection : IOperator
{
    public TruncateWithoutDigitsIntegerNullableProjection(
        DeclaresDecimalNullableProjection operand
    )
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
