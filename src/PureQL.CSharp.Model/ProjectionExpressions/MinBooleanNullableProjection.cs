using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MinBooleanNullableProjection : IOperator
{
    public MinBooleanNullableProjection(
        BooleanNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public BooleanNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeBooleanNullable();
}
