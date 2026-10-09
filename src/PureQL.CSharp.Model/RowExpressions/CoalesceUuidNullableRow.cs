namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceUuidNullableRow
{
    public CoalesceUuidNullableRow(IEnumerable<UuidNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableRow> Values { get; }
}
