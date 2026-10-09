namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record FloorIntegerProjection
{
    public FloorIntegerProjection(DecimalProjection value)
    {
        Value = value;
    }

    public DecimalProjection Value { get; }
}
