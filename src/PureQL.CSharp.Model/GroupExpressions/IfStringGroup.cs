namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfStringGroup
{
    public IfStringGroup(BooleanGroup condition, StringGroup then, StringGroup @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public StringGroup Then { get; }

    public StringGroup Else { get; }
}
