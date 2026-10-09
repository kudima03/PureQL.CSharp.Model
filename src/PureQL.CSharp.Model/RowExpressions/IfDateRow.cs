namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfDateRow
{
    public IfDateRow(BooleanRow condition, DateRow then, DateRow @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public DateRow Then { get; }

    public DateRow Else { get; }
}
