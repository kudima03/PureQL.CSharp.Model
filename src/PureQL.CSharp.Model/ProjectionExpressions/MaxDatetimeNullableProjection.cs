using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MaxDatetimeNullableProjection
{
    public MaxDatetimeNullableProjection(
        DatetimeNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public DatetimeNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }
}
