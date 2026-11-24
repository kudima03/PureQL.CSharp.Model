using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>position.integer@group</c>.</summary>
public sealed record PositionIntegerGroup : IOperator
{
    public PositionIntegerGroup(
        StringGroup operand,
        StringGroup pattern,
        IntegerGroup? start = null
    )
    {
        Operand = operand;
        Pattern = pattern;
        Start = start;
    }

    public StringGroup Operand { get; }

    public StringGroup Pattern { get; }

    public IntegerGroup? Start { get; }

    public IType Type => new TypeInteger();
}
