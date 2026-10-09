namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record NotProjection
{
    public NotProjection(BooleanProjection condition)
    {
        Condition = condition;
    }

    public BooleanProjection Condition { get; }
}
