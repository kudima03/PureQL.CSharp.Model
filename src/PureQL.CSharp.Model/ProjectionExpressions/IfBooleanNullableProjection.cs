namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfBooleanNullableProjection
{
    public IfBooleanNullableProjection(
        BooleanProjection condition,
        BooleanNullableProjection then,
        BooleanNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public BooleanNullableProjection Then { get; }

    public BooleanNullableProjection Else { get; }
}
