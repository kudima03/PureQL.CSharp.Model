using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>substring.string@projection</c>.</summary>
public sealed record SubstringStringProjection : IOperator
{
    public SubstringStringProjection(
        StringProjection operand,
        IntegerProjection start,
        IntegerProjection? length = null
    )
    {
        Operand = operand;
        Start = start;
        Length = length;
    }

    public StringProjection Operand { get; }

    public IntegerProjection Start { get; }

    public IntegerProjection? Length { get; }

    public IType Type => new TypeString();
}
