using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record DateDiffDaysIntegerRow : IOperator
{
    public DateDiffDaysIntegerRow(DateRow left, DateRow right)
    {
        Left = left;
        Right = right;
    }

    public DateRow Left { get; }

    public DateRow Right { get; }

    public IType Type => new TypeInteger();
}
