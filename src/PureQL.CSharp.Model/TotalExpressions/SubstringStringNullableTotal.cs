using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>substring.string.nullable@total</c>.</summary>
public sealed record SubstringStringNullableTotal : IOperator
{
    public SubstringStringNullableTotal(
        StringNullableTotal operand,
        IntegerNullableTotal start,
        IntegerNullableTotal? length = null
    )
    {
        Operand = operand;
        Start = start;
        Length = length;
    }

    public StringNullableTotal Operand { get; }

    public IntegerNullableTotal Start { get; }

    public IntegerNullableTotal? Length { get; }

    public IType Type => new TypeStringNullable();
}
