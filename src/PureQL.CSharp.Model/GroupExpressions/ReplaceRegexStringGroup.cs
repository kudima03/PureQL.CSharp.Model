using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>replaceRegex.string@group</c>.</summary>
public sealed record ReplaceRegexStringGroup : IOperator
{
    public ReplaceRegexStringGroup(
        StringGroup operand,
        StringGroup replacement,
        RegexPattern pattern
    )
    {
        Operand = operand;
        Replacement = replacement;
        Pattern = pattern;
    }

    public StringGroup Operand { get; }

    public StringGroup Replacement { get; }

    public RegexPattern Pattern { get; }

    public IType Type => new TypeString();
}
