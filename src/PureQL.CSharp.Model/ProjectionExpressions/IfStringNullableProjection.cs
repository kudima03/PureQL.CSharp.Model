namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfStringNullableProjection
{
    public IfStringNullableProjection(
        BooleanProjection condition,
        StringNullableProjection then,
        StringNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public StringNullableProjection Then { get; }

    public StringNullableProjection Else { get; }
}
