namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfTimeNullableRow
{
    public IfTimeNullableRow(
        BooleanRow condition,
        TimeNullableRow then,
        TimeNullableRow @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public TimeNullableRow Then { get; }

    public TimeNullableRow Else { get; }
}
