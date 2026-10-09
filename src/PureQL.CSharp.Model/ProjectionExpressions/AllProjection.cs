using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AllProjection
{
    public AllProjection(BooleanRow predicate)
    {
        Predicate = predicate;
    }

    public BooleanRow Predicate { get; }
}
