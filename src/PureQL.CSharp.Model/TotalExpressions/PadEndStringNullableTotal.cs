using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>padEnd.string.nullable@total</c>.</summary>
public sealed record PadEndStringNullableTotal : IOperator
{
    public PadEndStringNullableTotal(
        StringNullableTotal operand,
        IntegerNullableTotal length,
        StringNullableTotal fill
    )
    {
        Operand = operand;
        Length = length;
        Fill = fill;
    }

    public StringNullableTotal Operand { get; }

    public IntegerNullableTotal Length { get; }

    public StringNullableTotal Fill { get; }

    public IType Type => new TypeStringNullable();
}
