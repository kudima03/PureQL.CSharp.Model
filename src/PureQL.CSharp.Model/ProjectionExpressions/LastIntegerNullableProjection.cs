using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>last.integer.nullable@projection</c>.</summary>
public sealed record LastIntegerNullableProjection : IOperator
{
    public LastIntegerNullableProjection(
        IntegerNullableRow selector,
        IEnumerable<OrderItemRow> orderBy,
        BooleanRow? predicate = null,
        Window? over = null
    )
    {
        Predicate = predicate;
        Over = over;
        Selector = selector;
        OrderBy = orderBy;
    }

    public BooleanRow? Predicate { get; }

    public Window? Over { get; }

    public IntegerNullableRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeIntegerNullable();
}
