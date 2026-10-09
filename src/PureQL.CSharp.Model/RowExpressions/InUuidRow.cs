using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record InUuidRow
{
    public InUuidRow(UuidNullableRow value, ListUuid list)
    {
        Value = value;
        List = list;
    }

    public UuidNullableRow Value { get; }

    public ListUuid List { get; }
}
