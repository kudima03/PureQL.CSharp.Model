namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceUuidRow
{
    public CoalesceUuidRow(IEnumerable<UuidNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableRow> Values { get; }
}
