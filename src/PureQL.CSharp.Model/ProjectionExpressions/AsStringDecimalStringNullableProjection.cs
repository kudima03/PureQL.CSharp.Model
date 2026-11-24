using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asString.decimal.string.nullable@projection</c>.</summary>
public sealed record AsStringDecimalStringNullableProjection : IOperator
{
    public AsStringDecimalStringNullableProjection(
        IntegerNullableOrDecimalNullableProjection operand
    )
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableProjection Operand { get; }

    public IType Type => new TypeStringNullable();
}
