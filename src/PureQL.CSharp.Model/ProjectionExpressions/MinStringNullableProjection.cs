using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MinStringNullableProjection
{
    public MinStringNullableProjection(
        StringNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public StringNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }
}
