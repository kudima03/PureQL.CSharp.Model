namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfStringProjection
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
}
