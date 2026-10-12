using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record DatetimeDiffSecondsDecimalRow : IOperator
{
    public DatetimeDiffSecondsDecimalRow(DatetimeRow left, DatetimeRow right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeRow Left { get; }

    public DatetimeRow Right { get; }

    public IType Type => new TypeDecimal();
}
