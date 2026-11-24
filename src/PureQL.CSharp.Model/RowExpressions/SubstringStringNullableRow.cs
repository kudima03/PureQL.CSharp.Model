using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>substring.string.nullable@row</c>.</summary>
public sealed record SubstringStringNullableRow : IOperator
{
    public SubstringStringNullableRow(
        StringNullableRow operand,
        IntegerNullableRow start,
        IntegerNullableRow? length = null
    )
    {
        Operand = operand;
        Start = start;
        Length = length;
    }

    public StringNullableRow Operand { get; }

    public IntegerNullableRow Start { get; }

    public IntegerNullableRow? Length { get; }

    public IType Type => new TypeStringNullable();
}
