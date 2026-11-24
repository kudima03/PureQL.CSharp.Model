using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>upper.string@projection</c>.</summary>
public sealed record UpperStringProjection : IOperator
{
    public UpperStringProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeString();
}
