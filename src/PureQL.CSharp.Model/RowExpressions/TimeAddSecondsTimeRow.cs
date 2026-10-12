using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record TimeAddSecondsTimeRow : IOperator
{
    public TimeAddSecondsTimeRow(TimeRow left, DecimalRow right)
    {
        Left = left;
        Right = right;
    }

    public TimeRow Left { get; }

    public DecimalRow Right { get; }

    public IType Type => new TypeTime();
}
