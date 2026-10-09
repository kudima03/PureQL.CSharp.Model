using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AnyProjection
{
    public AnyProjection(BooleanRow predicate)
    {
        Predicate = predicate;
    }

    public BooleanRow Predicate { get; }
}
