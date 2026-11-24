using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetimeDiffMonths.integer@row</c>.</summary>
public sealed record DatetimeDiffMonthsIntegerRow : IOperator
{
    public DatetimeDiffMonthsIntegerRow(
        DatetimeRow left,
        DatetimeRow right,
        StringRow? zone = null
    )
    {
        Left = left;
        Right = right;
        Zone = zone;
    }

    public DatetimeRow Left { get; }

    public DatetimeRow Right { get; }

    public StringRow? Zone { get; }

    public IType Type => new TypeInteger();
}
