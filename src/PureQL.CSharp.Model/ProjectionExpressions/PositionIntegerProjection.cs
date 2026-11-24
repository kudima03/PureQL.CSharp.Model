using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>position.integer@projection</c>.</summary>
public sealed record PositionIntegerProjection : IOperator
{
    public PositionIntegerProjection(
        StringProjection operand,
        StringProjection pattern,
        IntegerProjection? start = null
    )
    {
        Operand = operand;
        Pattern = pattern;
        Start = start;
    }

    public StringProjection Operand { get; }

    public StringProjection Pattern { get; }

    public IntegerProjection? Start { get; }

    public IType Type => new TypeInteger();
}
