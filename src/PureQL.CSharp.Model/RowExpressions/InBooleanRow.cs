using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record InBooleanRow
{
    public InBooleanRow(BooleanNullableRow value, ListBoolean list)
    {
        Value = value;
        List = list;
    }

    public BooleanNullableRow Value { get; }

    public ListBoolean List { get; }
}
