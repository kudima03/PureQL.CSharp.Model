using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.string@projection</c>.</summary>
public sealed record IfStringProjection : IOperator
{
    public IfStringProjection(
        StringProjection then,
        StringProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public StringProjection Then { get; }

    public StringProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeString();
}
