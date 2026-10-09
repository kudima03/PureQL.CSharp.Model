namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfDatetimeNullableProjection
{
    public IfDatetimeNullableProjection(
        BooleanProjection condition,
        DatetimeNullableProjection then,
        DatetimeNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public DatetimeNullableProjection Then { get; }

    public DatetimeNullableProjection Else { get; }
}
