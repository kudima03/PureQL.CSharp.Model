namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfUuidNullableRow
{
    public IfUuidNullableRow(
        BooleanRow condition,
        UuidNullableRow then,
        UuidNullableRow @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public UuidNullableRow Then { get; }

    public UuidNullableRow Else { get; }
}
