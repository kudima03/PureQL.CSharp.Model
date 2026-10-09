namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfDatetimeGroup
{
    public IfDatetimeGroup(
        BooleanGroup condition,
        DatetimeGroup then,
        DatetimeGroup @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public DatetimeGroup Then { get; }

    public DatetimeGroup Else { get; }
}
