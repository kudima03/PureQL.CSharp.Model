namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfIntegerGroup
{
    public IfIntegerGroup(BooleanGroup condition, IntegerGroup then, IntegerGroup @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public IntegerGroup Then { get; }

    public IntegerGroup Else { get; }
}
