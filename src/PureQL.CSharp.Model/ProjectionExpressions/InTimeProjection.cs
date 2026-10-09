using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record InTimeProjection
{
    public InTimeProjection(TimeNullableProjection value, ListTime list)
    {
        Value = value;
        List = list;
    }

    public TimeNullableProjection Value { get; }

    public ListTime List { get; }
}
