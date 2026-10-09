namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfDateNullableProjection
{
    public IfDateNullableProjection(
        BooleanProjection condition,
        DateNullableProjection then,
        DateNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public DateNullableProjection Then { get; }

    public DateNullableProjection Else { get; }
}
