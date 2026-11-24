using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>matchesRegex@projection</c>.</summary>
public sealed record MatchesRegexProjection : IOperator
{
    public MatchesRegexProjection(StringNullableProjection operand, RegexPattern pattern)
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableProjection Operand { get; }

    public RegexPattern Pattern { get; }

    public IType Type => new TypeBoolean();
}
