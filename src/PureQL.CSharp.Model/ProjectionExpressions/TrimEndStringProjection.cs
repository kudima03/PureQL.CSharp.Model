using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>trimEnd.string@projection</c>.</summary>
public sealed record TrimEndStringProjection : IOperator
{
    public TrimEndStringProjection(
        StringProjection operand,
        IEnumerable<StringProjection> removables
    )
    {
        Operand = operand;
        Removables = removables;
    }

    public StringProjection Operand { get; }

    public IEnumerable<StringProjection> Removables { get; }

    public IType Type => new TypeString();
}
