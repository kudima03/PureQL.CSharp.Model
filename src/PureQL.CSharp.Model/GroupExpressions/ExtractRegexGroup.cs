using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>extractRegex@group</c>.</summary>
public sealed record ExtractRegexGroup : IOperator
{
    public ExtractRegexGroup(
        StringNullableGroup operand,
        RegexPattern pattern,
        RegexGroup? group = null
    )
    {
        Operand = operand;
        Pattern = pattern;
        Group = group;
    }

    public StringNullableGroup Operand { get; }

    public RegexPattern Pattern { get; }

    public RegexGroup? Group { get; }

    public IType Type => new TypeStringNullable();
}
