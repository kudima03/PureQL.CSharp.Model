namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AndProjection
{
    public AndProjection(IEnumerable<BooleanProjection> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanProjection> Conditions { get; }
}
