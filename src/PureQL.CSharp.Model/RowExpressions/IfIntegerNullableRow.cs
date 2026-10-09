namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfIntegerNullableRow
{
    public IfIntegerNullableRow(
        BooleanRow condition,
        IntegerNullableRow then,
        IntegerNullableRow @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public IntegerNullableRow Then { get; }

    public IntegerNullableRow Else { get; }
}
