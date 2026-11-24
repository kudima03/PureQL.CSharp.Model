using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asDecimal.string.decimal.nullable@row</c>.</summary>
public sealed record AsDecimalStringDecimalNullableRow : IOperator
{
    public AsDecimalStringDecimalNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
