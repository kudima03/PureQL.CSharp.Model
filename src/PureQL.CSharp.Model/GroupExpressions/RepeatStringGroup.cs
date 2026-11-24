using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>repeat.string@group</c>.</summary>
public sealed record RepeatStringGroup : IOperator
{
    public RepeatStringGroup(StringGroup operand, IntegerGroup count)
    {
        Operand = operand;
        Count = count;
    }

    public StringGroup Operand { get; }

    public IntegerGroup Count { get; }

    public IType Type => new TypeString();
}
