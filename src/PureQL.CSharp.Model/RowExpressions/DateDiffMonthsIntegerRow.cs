using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dateDiffMonths.integer@row</c>.</summary>
public sealed record DateDiffMonthsIntegerRow : IOperator
{
    public DateDiffMonthsIntegerRow(DateRow left, DateRow right)
    {
        Left = left;
        Right = right;
    }

    public DateRow Left { get; }

    public DateRow Right { get; }

    public IType Type => new TypeInteger();
}
