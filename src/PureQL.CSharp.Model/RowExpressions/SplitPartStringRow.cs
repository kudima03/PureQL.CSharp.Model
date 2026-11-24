using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>splitPart.string@row</c>.</summary>
public sealed record SplitPartStringRow : IOperator
{
    public SplitPartStringRow(StringRow operand, StringRow delimiter, IntegerRow index)
    {
        Operand = operand;
        Delimiter = delimiter;
        Index = index;
    }

    public StringRow Operand { get; }

    public StringRow Delimiter { get; }

    public IntegerRow Index { get; }

    public IType Type => new TypeString();
}
