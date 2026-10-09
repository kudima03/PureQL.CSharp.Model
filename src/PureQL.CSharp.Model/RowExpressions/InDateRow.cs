using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record InDateRow
{
    public InDateRow(DateNullableRow value, ListDate list)
    {
        Value = value;
        List = list;
    }

    public DateNullableRow Value { get; }

    public ListDate List { get; }
}
