using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>replaceRegex.string.nullable@group</c>.</summary>
public sealed record ReplaceRegexStringNullableGroup : IOperator
{
    public ReplaceRegexStringNullableGroup(
        StringNullableGroup operand,
        StringNullableGroup replacement,
        RegexPattern pattern
    )
    {
        Operand = operand;
        Replacement = replacement;
        Pattern = pattern;
    }

    public StringNullableGroup Operand { get; }

    public StringNullableGroup Replacement { get; }

    public RegexPattern Pattern { get; }

    public IType Type => new TypeStringNullable();
}
