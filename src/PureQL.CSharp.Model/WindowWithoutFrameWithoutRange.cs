using PureQL.CSharp.Model.RowExpressions;

namespace PureQL.CSharp.Model;

public sealed record WindowWithoutFrameWithoutRange
{
    public WindowWithoutFrameWithoutRange(IEnumerable<ExprRow> partitionBy)
    {
        PartitionBy = partitionBy;
    }

    public IEnumerable<ExprRow> PartitionBy { get; }
}
