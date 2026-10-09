namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfIntegerRow
{
    public IfIntegerRow(BooleanRow condition, IntegerRow then, IntegerRow @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public IntegerRow Then { get; }

    public IntegerRow Else { get; }
}
