namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record OrProjection
{
    public OrProjection(IEnumerable<BooleanProjection> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanProjection> Conditions { get; }
}
