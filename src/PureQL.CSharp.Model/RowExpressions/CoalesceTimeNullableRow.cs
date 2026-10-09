namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceTimeNullableRow
{
    public CoalesceTimeNullableRow(IEnumerable<TimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableRow> Values { get; }
}
