using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>truncate.withoutDigits.integer.nullable@row</c>.</summary>
public sealed record TruncateWithoutDigitsIntegerNullableRow : IOperator
{
    public TruncateWithoutDigitsIntegerNullableRow(DeclaresDecimalNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
