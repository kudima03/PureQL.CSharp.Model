using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>matchesRegex@group</c>.</summary>
public sealed record MatchesRegexGroup : IOperator
{
    public MatchesRegexGroup(StringNullableGroup operand, RegexPattern pattern)
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableGroup Operand { get; }

    public RegexPattern Pattern { get; }

    public IType Type => new TypeBoolean();
}
