using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record WindowWithoutFrameWithRangeDate
{
    public WindowWithoutFrameWithRangeDate(
        IEnumerable<OrderItemDateRow> orderBy,
        RangeDate range,
        IEnumerable<ExprRow>? partitionBy = null
    )
    {
        PartitionBy = partitionBy;
        OrderBy = orderBy;
        Range = range;
    }

    public IEnumerable<ExprRow>? PartitionBy { get; }

    public IEnumerable<OrderItemDateRow> OrderBy { get; }

    public RangeDate Range { get; }
}
