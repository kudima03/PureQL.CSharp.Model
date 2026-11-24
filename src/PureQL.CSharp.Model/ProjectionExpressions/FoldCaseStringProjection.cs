using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>foldCase.string@projection</c>.</summary>
public sealed record FoldCaseStringProjection : IOperator
{
    public FoldCaseStringProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeString();
}
