using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record TimeDiffSecondsDecimalRow : IOperator
{
    public TimeDiffSecondsDecimalRow(TimeRow left, TimeRow right)
    {
        Left = left;
        Right = right;
    }

    public TimeRow Left { get; }

    public TimeRow Right { get; }

    public IType Type => new TypeDecimal();
}
