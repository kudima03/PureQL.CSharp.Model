using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>padStart.string@projection</c>.</summary>
public sealed record PadStartStringProjection : IOperator
{
    public PadStartStringProjection(
        StringProjection operand,
        IntegerProjection length,
        StringProjection fill
    )
    {
        Operand = operand;
        Length = length;
        Fill = fill;
    }

    public StringProjection Operand { get; }

    public IntegerProjection Length { get; }

    public StringProjection Fill { get; }

    public IType Type => new TypeString();
}
