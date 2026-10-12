using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record DateAddDaysDateRow : IOperator
{
    public DateAddDaysDateRow(DateRow left, IntegerRow right)
    {
        Left = left;
        Right = right;
    }

    public DateRow Left { get; }

    public IntegerRow Right { get; }

    public IType Type => new TypeDate();
}
