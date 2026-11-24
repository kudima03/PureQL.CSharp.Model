using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>padStart.string.nullable@total</c>.</summary>
public sealed record PadStartStringNullableTotal : IOperator
{
    public PadStartStringNullableTotal(
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
