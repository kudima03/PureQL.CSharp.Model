using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>replaceRegex.string.nullable@projection</c>.</summary>
public sealed record ReplaceRegexStringNullableProjection : IOperator
{
    public ReplaceRegexStringNullableProjection(
        StringNullableProjection operand,
        StringNullableProjection replacement,
        RegexPattern pattern
    )
    {
        Operand = operand;
        Replacement = replacement;
        Pattern = pattern;
    }

    public StringNullableProjection Operand { get; }

    public StringNullableProjection Replacement { get; }

    public RegexPattern Pattern { get; }

    public IType Type => new TypeStringNullable();
}
