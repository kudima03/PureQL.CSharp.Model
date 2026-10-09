namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfDateNullableGroup
{
    public IfDateNullableGroup(
        BooleanGroup condition,
        DateNullableGroup then,
        DateNullableGroup @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public DateNullableGroup Then { get; }

    public DateNullableGroup Else { get; }
}
