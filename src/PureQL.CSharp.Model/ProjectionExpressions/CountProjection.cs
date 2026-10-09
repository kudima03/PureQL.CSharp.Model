using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CountProjection
{
    public CountProjection(BooleanRow? predicate = null)
    {
        Predicate = predicate;
    }

    public BooleanRow? Predicate { get; }
}
