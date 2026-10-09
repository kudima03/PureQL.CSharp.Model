using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MaxTimeNullableProjection
{
    public MaxTimeNullableProjection(
        TimeNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public TimeNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }
}
