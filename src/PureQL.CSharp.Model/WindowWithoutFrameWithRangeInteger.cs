using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record WindowWithoutFrameWithRangeInteger
{
    public WindowWithoutFrameWithRangeInteger(
        IEnumerable<OrderItemIntegerRow> orderBy,
        RangeInteger range,
        IEnumerable<ExprRow>? partitionBy = null
    )
    {
        PartitionBy = partitionBy;
        OrderBy = orderBy;
        Range = range;
    }

    public IEnumerable<ExprRow>? PartitionBy { get; }

    public IEnumerable<OrderItemIntegerRow> OrderBy { get; }

    public RangeInteger Range { get; }
}
