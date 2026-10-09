namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CeilingIntegerProjection
{
    public CeilingIntegerProjection(DecimalProjection value)
    {
        Value = value;
    }

    public DecimalProjection Value { get; }
}
