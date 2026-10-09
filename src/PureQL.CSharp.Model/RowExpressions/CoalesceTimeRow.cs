namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceTimeRow
{
    public CoalesceTimeRow(IEnumerable<TimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableRow> Values { get; }
}
