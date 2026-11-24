using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>repeat.string@projection</c>.</summary>
public sealed record RepeatStringProjection : IOperator
{
    public RepeatStringProjection(StringProjection operand, IntegerProjection count)
    {
        Operand = operand;
        Count = count;
    }

    public StringProjection Operand { get; }

    public IntegerProjection Count { get; }

    public IType Type => new TypeString();
}
