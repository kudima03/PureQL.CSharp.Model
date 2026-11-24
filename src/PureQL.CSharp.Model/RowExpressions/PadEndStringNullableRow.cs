using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>padEnd.string.nullable@row</c>.</summary>
public sealed record PadEndStringNullableRow : IOperator
{
    public PadEndStringNullableRow(
        StringNullableRow operand,
        IntegerNullableRow length,
        StringNullableRow fill
    )
    {
        Operand = operand;
        Length = length;
        Fill = fill;
    }

    public StringNullableRow Operand { get; }

    public IntegerNullableRow Length { get; }

    public StringNullableRow Fill { get; }

    public IType Type => new TypeStringNullable();
}
