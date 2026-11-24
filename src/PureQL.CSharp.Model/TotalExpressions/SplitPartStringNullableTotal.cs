using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>splitPart.string.nullable@total</c>.</summary>
public sealed record SplitPartStringNullableTotal : IOperator
{
    public SplitPartStringNullableTotal(
        StringNullableTotal operand,
        StringNullableTotal delimiter,
        IntegerNullableTotal index
    )
    {
        Operand = operand;
        Delimiter = delimiter;
        Index = index;
    }

    public StringNullableTotal Operand { get; }

    public StringNullableTotal Delimiter { get; }

    public IntegerNullableTotal Index { get; }

    public IType Type => new TypeStringNullable();
}
