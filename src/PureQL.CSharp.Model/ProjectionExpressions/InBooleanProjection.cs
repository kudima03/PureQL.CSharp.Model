using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record InBooleanProjection
{
    public InBooleanProjection(BooleanNullableProjection value, ListBoolean list)
    {
        Value = value;
        List = list;
    }

    public BooleanNullableProjection Value { get; }

    public ListBoolean List { get; }
}
