using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>repeat.string.nullable@row</c>.</summary>
public sealed record RepeatStringNullableRow : IOperator
{
    public RepeatStringNullableRow(StringNullableRow operand, IntegerNullableRow count)
    {
        Operand = operand;
        Count = count;
    }

    public StringNullableRow Operand { get; }

    public IntegerNullableRow Count { get; }

    public IType Type => new TypeStringNullable();
}
