using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>replaceRegex.string.nullable@total</c>.</summary>
public sealed record ReplaceRegexStringNullableTotal : IOperator
{
    public ReplaceRegexStringNullableTotal(
        StringNullableTotal operand,
        StringNullableTotal replacement,
        RegexPattern pattern
    )
    {
        Operand = operand;
        Replacement = replacement;
        Pattern = pattern;
    }

    public StringNullableTotal Operand { get; }

    public StringNullableTotal Replacement { get; }

    public RegexPattern Pattern { get; }

    public IType Type => new TypeStringNullable();
}
