namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfIntegerProjection
{
    public IfIntegerProjection(
        BooleanProjection condition,
        IntegerProjection then,
        IntegerProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public IntegerProjection Then { get; }

    public IntegerProjection Else { get; }
}
