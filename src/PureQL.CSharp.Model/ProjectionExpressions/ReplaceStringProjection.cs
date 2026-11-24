using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>replace.string@projection</c>.</summary>
public sealed record ReplaceStringProjection : IOperator
{
    public ReplaceStringProjection(
        StringProjection operand,
        StringProjection pattern,
        StringProjection replacement
    )
    {
        Operand = operand;
        Pattern = pattern;
        Replacement = replacement;
    }

    public StringProjection Operand { get; }

    public StringProjection Pattern { get; }

    public StringProjection Replacement { get; }

    public IType Type => new TypeString();
}
