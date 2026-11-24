using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>last.uuid@projection</c>.</summary>
public sealed record LastUuidProjection : IOperator
{
    public LastUuidProjection(
        UuidRow selector,
        IEnumerable<OrderItemRow> orderBy,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        OrderBy = orderBy;
    }

    public Window? Over { get; }

    public UuidRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeUuid();
}
