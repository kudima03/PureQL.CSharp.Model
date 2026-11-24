using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>replaceRegex.string@projection</c>.</summary>
public sealed record ReplaceRegexStringProjection : IOperator
{
    public ReplaceRegexStringProjection(
        StringProjection operand,
        StringProjection replacement,
        RegexPattern pattern
    )
    {
        Operand = operand;
        Replacement = replacement;
        Pattern = pattern;
    }

    public StringProjection Operand { get; }

    public StringProjection Replacement { get; }

    public RegexPattern Pattern { get; }

    public IType Type => new TypeString();
}
