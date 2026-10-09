using PureQL.CSharp.Model.Lists;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record InDecimalProjection
{
    public InDecimalProjection(DecimalNullableProjection value, ListDecimal list)
    {
        Value = value;
        List = list;
    }

    public DecimalNullableProjection Value { get; }

    public ListDecimal List { get; }
}
