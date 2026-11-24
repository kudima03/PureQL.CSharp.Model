using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record WindowWithoutFrameWithRangeDatetime
{
    public WindowWithoutFrameWithRangeDatetime(
        IEnumerable<OrderItemDatetimeRow> orderBy,
        RangeDatetime range,
        IEnumerable<ExprRow>? partitionBy = null
    )
    {
        PartitionBy = partitionBy;
        OrderBy = orderBy;
        Range = range;
    }

    public IEnumerable<ExprRow>? PartitionBy { get; }

    public IEnumerable<OrderItemDatetimeRow> OrderBy { get; }

    public RangeDatetime Range { get; }
}
