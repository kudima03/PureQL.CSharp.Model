using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>first.integer.nullable@projection</c>.</summary>
public sealed record FirstIntegerNullableProjection : IOperator
{
    public FirstIntegerNullableProjection(
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
