namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfBooleanProjection
{
    public IfBooleanProjection(
        BooleanProjection condition,
        BooleanProjection then,
        BooleanProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public BooleanProjection Then { get; }

    public BooleanProjection Else { get; }
}
