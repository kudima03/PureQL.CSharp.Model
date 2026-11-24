using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>repeat.string.nullable@total</c>.</summary>
public sealed record RepeatStringNullableTotal : IOperator
{
    public RepeatStringNullableTotal(
        StringNullableTotal operand,
        IntegerNullableTotal count
    )
    {
        Operand = operand;
        Count = count;
    }

    public StringNullableTotal Operand { get; }

    public IntegerNullableTotal Count { get; }

    public IType Type => new TypeStringNullable();
}
