using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record InTimeRow
{
    public InTimeRow(TimeNullableRow value, ListTime list)
    {
        Value = value;
        List = list;
    }

    public TimeNullableRow Value { get; }

    public ListTime List { get; }
}
