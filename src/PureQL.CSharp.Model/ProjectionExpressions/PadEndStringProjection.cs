using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>padEnd.string@projection</c>.</summary>
public sealed record PadEndStringProjection : IOperator
{
    public PadEndStringProjection(
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
