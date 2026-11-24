using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>splitPart.string@projection</c>.</summary>
public sealed record SplitPartStringProjection : IOperator
{
    public SplitPartStringProjection(
        StringProjection operand,
        StringProjection delimiter,
        IntegerProjection index
    )
    {
        Operand = operand;
        Delimiter = delimiter;
        Index = index;
    }

    public StringProjection Operand { get; }

    public StringProjection Delimiter { get; }

    public IntegerProjection Index { get; }

    public IType Type => new TypeString();
}
