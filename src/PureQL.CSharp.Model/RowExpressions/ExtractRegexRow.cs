using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>extractRegex@row</c>.</summary>
public sealed record ExtractRegexRow : IOperator
{
    public ExtractRegexRow(
        StringNullableRow operand,
        RegexPattern pattern,
        RegexGroup? group = null
    )
    {
        Operand = operand;
        Pattern = pattern;
        Group = group;
    }

    public StringNullableRow Operand { get; }

    public RegexPattern Pattern { get; }

    public RegexGroup? Group { get; }

    public IType Type => new TypeStringNullable();
}
