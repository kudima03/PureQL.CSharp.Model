namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfDatetimeRow
{
    public IfDatetimeRow(BooleanRow condition, DatetimeRow then, DatetimeRow @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public DatetimeRow Then { get; }

    public DatetimeRow Else { get; }
}
