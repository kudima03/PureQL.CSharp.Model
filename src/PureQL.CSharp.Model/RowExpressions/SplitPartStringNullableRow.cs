using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>splitPart.string.nullable@row</c>.</summary>
public sealed record SplitPartStringNullableRow : IOperator
{
    public SplitPartStringNullableRow(
        StringNullableRow operand,
        StringNullableRow delimiter,
        IntegerNullableRow index
    )
    {
        Operand = operand;
        Delimiter = delimiter;
        Index = index;
    }

    public StringNullableRow Operand { get; }

    public StringNullableRow Delimiter { get; }

    public IntegerNullableRow Index { get; }

    public IType Type => new TypeStringNullable();
}
