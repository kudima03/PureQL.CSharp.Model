namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfDecimalRow
{
    public IfDecimalRow(BooleanRow condition, DecimalRow then, DecimalRow @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public DecimalRow Then { get; }

    public DecimalRow Else { get; }
}
