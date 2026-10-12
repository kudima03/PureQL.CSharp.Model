using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MinTimeNullableProjection : IOperator
{
    public MinTimeNullableProjection(
        TimeNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public TimeNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeTimeNullable();
}
