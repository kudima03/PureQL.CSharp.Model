using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record InStringRow
{
    public InStringRow(StringNullableRow value, ListString list)
    {
        Value = value;
        List = list;
    }

    public StringNullableRow Value { get; }

    public ListString List { get; }
}
