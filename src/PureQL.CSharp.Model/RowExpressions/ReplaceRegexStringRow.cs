using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>replaceRegex.string@row</c>.</summary>
public sealed record ReplaceRegexStringRow : IOperator
{
    public ReplaceRegexStringRow(
        StringRow operand,
        StringRow replacement,
        RegexPattern pattern
    )
    {
        Operand = operand;
        Replacement = replacement;
        Pattern = pattern;
    }

    public StringRow Operand { get; }

    public StringRow Replacement { get; }

    public RegexPattern Pattern { get; }

    public IType Type => new TypeString();
}
