namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfIntegerNullableGroup
{
    public IfIntegerNullableGroup(
        BooleanGroup condition,
        IntegerNullableGroup then,
        IntegerNullableGroup @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public IntegerNullableGroup Then { get; }

    public IntegerNullableGroup Else { get; }
}
