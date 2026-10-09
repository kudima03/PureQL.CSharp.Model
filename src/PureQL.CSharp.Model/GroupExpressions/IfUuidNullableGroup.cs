namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfUuidNullableGroup
{
    public IfUuidNullableGroup(
        BooleanGroup condition,
        UuidNullableGroup then,
        UuidNullableGroup @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public UuidNullableGroup Then { get; }

    public UuidNullableGroup Else { get; }
}
