using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MinDateNullableProjection
{
    public MinDateNullableProjection(
        DateNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public DateNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }
}
