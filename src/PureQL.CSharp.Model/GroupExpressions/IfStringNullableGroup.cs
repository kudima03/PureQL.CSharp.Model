namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfStringNullableGroup
{
    public IfStringNullableGroup(
        BooleanGroup condition,
        StringNullableGroup then,
        StringNullableGroup @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public StringNullableGroup Then { get; }

    public StringNullableGroup Else { get; }
}
