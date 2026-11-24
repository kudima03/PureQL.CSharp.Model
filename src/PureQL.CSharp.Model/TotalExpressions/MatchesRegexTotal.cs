using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>matchesRegex@total</c>.</summary>
public sealed record MatchesRegexTotal : IOperator
{
    public MatchesRegexTotal(StringNullableTotal operand, RegexPattern pattern)
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableTotal Operand { get; }

    public RegexPattern Pattern { get; }

    public IType Type => new TypeBoolean();
}
