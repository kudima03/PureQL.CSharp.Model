namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfTimeNullableProjection
{
    public IfTimeNullableProjection(
        BooleanProjection condition,
        TimeNullableProjection then,
        TimeNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public TimeNullableProjection Then { get; }

    public TimeNullableProjection Else { get; }
}
