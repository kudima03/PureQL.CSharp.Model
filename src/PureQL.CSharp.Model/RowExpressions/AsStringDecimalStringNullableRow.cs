using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asString.decimal.string.nullable@row</c>.</summary>
public sealed record AsStringDecimalStringNullableRow : IOperator
{
    public AsStringDecimalStringNullableRow(IntegerNullableOrDecimalNullableRow operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableRow Operand { get; }

    public IType Type => new TypeStringNullable();
}
