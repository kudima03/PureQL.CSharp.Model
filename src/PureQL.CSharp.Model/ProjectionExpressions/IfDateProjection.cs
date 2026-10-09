namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfDateProjection
{
    public IfDateProjection(
        BooleanProjection condition,
        DateProjection then,
        DateProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public DateProjection Then { get; }

    public DateProjection Else { get; }
}
