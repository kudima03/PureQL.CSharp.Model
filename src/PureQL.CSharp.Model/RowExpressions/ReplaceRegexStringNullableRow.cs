using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>replaceRegex.string.nullable@row</c>.</summary>
public sealed record ReplaceRegexStringNullableRow : IOperator
{
    public ReplaceRegexStringNullableRow(
        StringNullableRow operand,
        StringNullableRow replacement,
        RegexPattern pattern
    )
    {
        Operand = operand;
        Replacement = replacement;
        Pattern = pattern;
    }

    public StringNullableRow Operand { get; }

    public StringNullableRow Replacement { get; }

    public RegexPattern Pattern { get; }

    public IType Type => new TypeStringNullable();
}
