namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record FloorIntegerNullableProjection
{
    public FloorIntegerNullableProjection(DecimalNullableProjection value)
    {
        Value = value;
    }

    public DecimalNullableProjection Value { get; }
}
