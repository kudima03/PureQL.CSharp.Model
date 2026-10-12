using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MaxUuidNullableProjection : IOperator
{
    public MaxUuidNullableProjection(
        UuidNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public UuidNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeUuidNullable();
}
