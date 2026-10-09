namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfDecimalNullableProjection
{
    public IfDecimalNullableProjection(
        BooleanProjection condition,
        DecimalNullableProjection then,
        DecimalNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public DecimalNullableProjection Then { get; }

    public DecimalNullableProjection Else { get; }
}
