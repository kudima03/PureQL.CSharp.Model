using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>removeDiacritics.string@projection</c>.</summary>
public sealed record RemoveDiacriticsStringProjection : IOperator
{
    public RemoveDiacriticsStringProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeString();
}
