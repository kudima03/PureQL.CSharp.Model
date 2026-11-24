using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>reverse.string@projection</c>.</summary>
public sealed record ReverseStringProjection : IOperator
{
    public ReverseStringProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeString();
}
