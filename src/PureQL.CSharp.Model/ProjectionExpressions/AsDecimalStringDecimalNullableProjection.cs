using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asDecimal.string.decimal.nullable@projection</c>.</summary>
public sealed record AsDecimalStringDecimalNullableProjection : IOperator
{
    public AsDecimalStringDecimalNullableProjection(
        DeclaresStringNullableProjection operand
    )
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
