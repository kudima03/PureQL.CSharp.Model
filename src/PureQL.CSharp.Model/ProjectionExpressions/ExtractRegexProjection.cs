using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>extractRegex@projection</c>.</summary>
public sealed record ExtractRegexProjection : IOperator
{
    public ExtractRegexProjection(
        StringNullableProjection operand,
        RegexPattern pattern,
        RegexGroup? group = null
    )
    {
        Operand = operand;
        Pattern = pattern;
        Group = group;
    }

    public StringNullableProjection Operand { get; }

    public RegexPattern Pattern { get; }

    public RegexGroup? Group { get; }

    public IType Type => new TypeStringNullable();
}
