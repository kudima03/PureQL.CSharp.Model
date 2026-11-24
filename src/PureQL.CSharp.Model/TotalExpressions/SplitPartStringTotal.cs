using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>splitPart.string@total</c>.</summary>
public sealed record SplitPartStringTotal : IOperator
{
    public SplitPartStringTotal(
        StringTotal operand,
        StringTotal delimiter,
        IntegerTotal index
    )
    {
        Operand = operand;
        Delimiter = delimiter;
        Index = index;
    }

    public StringTotal Operand { get; }

    public StringTotal Delimiter { get; }

    public IntegerTotal Index { get; }

    public IType Type => new TypeString();
}
