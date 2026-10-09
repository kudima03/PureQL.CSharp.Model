namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfDatetimeNullableRow
{
    public IfDatetimeNullableRow(
        BooleanRow condition,
        DatetimeNullableRow then,
        DatetimeNullableRow @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public DatetimeNullableRow Then { get; }

    public DatetimeNullableRow Else { get; }
}
