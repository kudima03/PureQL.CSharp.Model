using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>splitPart.string@group</c>.</summary>
public sealed record SplitPartStringGroup : IOperator
{
    public SplitPartStringGroup(
        StringGroup operand,
        StringGroup delimiter,
        IntegerGroup index
    )
    {
        Operand = operand;
        Delimiter = delimiter;
        Index = index;
    }

    public StringGroup Operand { get; }

    public StringGroup Delimiter { get; }

    public IntegerGroup Index { get; }

    public IType Type => new TypeString();
}
