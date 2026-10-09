namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record RoundIntegerProjection
{
    public RoundIntegerProjection(DecimalProjection value)
    {
        Value = value;
    }

    public DecimalProjection Value { get; }
}
