using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>lower.string@projection</c>.</summary>
public sealed record LowerStringProjection : IOperator
{
    public LowerStringProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeString();
}
