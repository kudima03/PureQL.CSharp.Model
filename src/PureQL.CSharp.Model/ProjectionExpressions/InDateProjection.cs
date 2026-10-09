using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record InDateProjection
{
    public InDateProjection(DateNullableProjection value, ListDate list)
    {
        Value = value;
        List = list;
    }

    public DateNullableProjection Value { get; }

    public ListDate List { get; }
}
