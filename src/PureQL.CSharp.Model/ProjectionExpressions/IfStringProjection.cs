using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfStringProjection : IOperator
{
    public IfStringProjection(
        BooleanProjection condition,
        StringProjection then,
        StringProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public StringProjection Then { get; }

    public StringProjection Else { get; }

    public IType Type => new TypeString();
}
