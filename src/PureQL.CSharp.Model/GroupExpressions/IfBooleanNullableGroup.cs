namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfBooleanNullableGroup
{
    public IfBooleanNullableGroup(
        BooleanGroup condition,
        BooleanNullableGroup then,
        BooleanNullableGroup @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public BooleanNullableGroup Then { get; }

    public BooleanNullableGroup Else { get; }
}
