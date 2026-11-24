using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>truncate.withoutDigits.integer.nullable@total</c>.</summary>
public sealed record TruncateWithoutDigitsIntegerNullableTotal : IOperator
{
    public TruncateWithoutDigitsIntegerNullableTotal(DeclaresDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
