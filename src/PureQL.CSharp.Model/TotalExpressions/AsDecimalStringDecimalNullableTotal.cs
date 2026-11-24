using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asDecimal.string.decimal.nullable@total</c>.</summary>
public sealed record AsDecimalStringDecimalNullableTotal : IOperator
{
    public AsDecimalStringDecimalNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
