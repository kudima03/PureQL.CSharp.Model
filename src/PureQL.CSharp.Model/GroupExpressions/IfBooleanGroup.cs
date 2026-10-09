namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfBooleanGroup
{
    public IfBooleanGroup(BooleanGroup condition, BooleanGroup then, BooleanGroup @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public BooleanGroup Then { get; }

    public BooleanGroup Else { get; }
}
