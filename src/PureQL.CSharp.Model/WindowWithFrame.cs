using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record WindowWithFrame
{
    public WindowWithFrame(
        IEnumerable<OrderItemRow> orderBy,
        Frame frame,
        IEnumerable<ExprRow>? partitionBy = null
    )
    {
        PartitionBy = partitionBy;
        OrderBy = orderBy;
        Frame = frame;
    }

    public IEnumerable<ExprRow>? PartitionBy { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public Frame Frame { get; }
}
