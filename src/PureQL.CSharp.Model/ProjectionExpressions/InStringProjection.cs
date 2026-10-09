using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record InStringProjection
{
    public InStringProjection(StringNullableProjection value, ListString list)
    {
        Value = value;
        List = list;
    }

    public StringNullableProjection Value { get; }

    public ListString List { get; }
}
