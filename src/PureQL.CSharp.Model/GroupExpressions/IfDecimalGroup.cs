namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfDecimalGroup
{
    public IfDecimalGroup(BooleanGroup condition, DecimalGroup then, DecimalGroup @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public DecimalGroup Then { get; }

    public DecimalGroup Else { get; }
}
