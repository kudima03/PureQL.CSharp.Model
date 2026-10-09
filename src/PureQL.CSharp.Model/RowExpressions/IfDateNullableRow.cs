namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfDateNullableRow
{
    public IfDateNullableRow(
        BooleanRow condition,
        DateNullableRow then,
        DateNullableRow @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public DateNullableRow Then { get; }

    public DateNullableRow Else { get; }
}
