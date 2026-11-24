using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asString.decimal.string.nullable@total</c>.</summary>
public sealed record AsStringDecimalStringNullableTotal : IOperator
{
    public AsStringDecimalStringNullableTotal(
        IntegerNullableOrDecimalNullableTotal operand
    )
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableTotal Operand { get; }

    public IType Type => new TypeStringNullable();
}
