using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record InDatetimeProjection
{
    public InDatetimeProjection(DatetimeNullableProjection value, ListDatetime list)
    {
        Value = value;
        List = list;
    }

    public DatetimeNullableProjection Value { get; }

    public ListDatetime List { get; }
}
