using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>replace.string@group</c>.</summary>
public sealed record ReplaceStringGroup : IOperator
{
    public ReplaceStringGroup(
        StringGroup operand,
        StringGroup pattern,
        StringGroup replacement
    )
    {
        Operand = operand;
        Pattern = pattern;
        Replacement = replacement;
    }

    public StringGroup Operand { get; }

    public StringGroup Pattern { get; }

    public StringGroup Replacement { get; }

    public IType Type => new TypeString();
}
