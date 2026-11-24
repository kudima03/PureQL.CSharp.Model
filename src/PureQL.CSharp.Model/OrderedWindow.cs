using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>orderedWindow</c>.</summary>
public sealed record OrderedWindow
{
    public OrderedWindow(
        IEnumerable<OrderItemRow> orderBy,
        IEnumerable<ExprRow>? partitionBy = null
    )
    {
        PartitionBy = partitionBy;
        OrderBy = orderBy;
    }

    public IEnumerable<ExprRow>? PartitionBy { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }
}
