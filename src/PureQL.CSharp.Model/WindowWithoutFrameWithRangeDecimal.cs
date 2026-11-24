using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record WindowWithoutFrameWithRangeDecimal
{
    public WindowWithoutFrameWithRangeDecimal(
        IEnumerable<OrderItemDecimalRow> orderBy,
        RangeDecimal range,
        IEnumerable<ExprRow>? partitionBy = null
    )
    {
        PartitionBy = partitionBy;
        OrderBy = orderBy;
        Range = range;
    }

    public IEnumerable<ExprRow>? PartitionBy { get; }

    public IEnumerable<OrderItemDecimalRow> OrderBy { get; }

    public RangeDecimal Range { get; }
}
