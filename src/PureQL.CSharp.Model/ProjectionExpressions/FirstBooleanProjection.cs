using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>first.boolean@projection</c>.</summary>
public sealed record FirstBooleanProjection : IOperator
{
    public FirstBooleanProjection(
        BooleanRow selector,
        IEnumerable<OrderItemRow> orderBy,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        OrderBy = orderBy;
    }

    public Window? Over { get; }

    public BooleanRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeBoolean();
}
