using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>replaceRegex.string@total</c>.</summary>
public sealed record ReplaceRegexStringTotal : IOperator
{
    public ReplaceRegexStringTotal(
        StringTotal operand,
        StringTotal replacement,
        RegexPattern pattern
    )
    {
        Operand = operand;
        Replacement = replacement;
        Pattern = pattern;
    }

    public StringTotal Operand { get; }

    public StringTotal Replacement { get; }

    public RegexPattern Pattern { get; }

    public IType Type => new TypeString();
}
