using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>matchesRegex@row</c>.</summary>
public sealed record MatchesRegexRow : IOperator
{
    public MatchesRegexRow(StringNullableRow operand, RegexPattern pattern)
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableRow Operand { get; }

    public RegexPattern Pattern { get; }

    public IType Type => new TypeBoolean();
}
