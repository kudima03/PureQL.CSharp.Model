namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfIntegerNullableProjection
{
    public IfIntegerNullableProjection(
        BooleanProjection condition,
        IntegerNullableProjection then,
        IntegerNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public IntegerNullableProjection Then { get; }

    public IntegerNullableProjection Else { get; }
}
