namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfDecimalNullableGroup
{
    public IfDecimalNullableGroup(
        BooleanGroup condition,
        DecimalNullableGroup then,
        DecimalNullableGroup @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public DecimalNullableGroup Then { get; }

    public DecimalNullableGroup Else { get; }
}
