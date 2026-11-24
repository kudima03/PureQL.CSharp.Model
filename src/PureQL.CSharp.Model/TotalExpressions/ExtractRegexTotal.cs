using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>extractRegex@total</c>.</summary>
public sealed record ExtractRegexTotal : IOperator
{
    public ExtractRegexTotal(
        StringNullableTotal operand,
        RegexPattern pattern,
        RegexGroup? group = null
    )
    {
        Operand = operand;
        Pattern = pattern;
        Group = group;
    }

    public StringNullableTotal Operand { get; }

    public RegexPattern Pattern { get; }

    public RegexGroup? Group { get; }

    public IType Type => new TypeStringNullable();
}
