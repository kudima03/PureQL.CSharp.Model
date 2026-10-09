namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfUuidNullableProjection
{
    public IfUuidNullableProjection(
        BooleanProjection condition,
        UuidNullableProjection then,
        UuidNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public UuidNullableProjection Then { get; }

    public UuidNullableProjection Else { get; }
}
