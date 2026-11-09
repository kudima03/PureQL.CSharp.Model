using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>min.time.nullable@projection</c>.</summary>
public sealed record MinTimeNullableProjection : IOperator
{
    public MinTimeNullableProjection(
        TimeNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public TimeNullableRow Selector { get; }

    public IType Type => new TypeTimeNullable();
}
