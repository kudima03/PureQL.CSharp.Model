using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record InDatetimeRow
{
    public InDatetimeRow(DatetimeNullableRow value, ListDatetime list)
    {
        Value = value;
        List = list;
    }

    public DatetimeNullableRow Value { get; }

    public ListDatetime List { get; }
}
