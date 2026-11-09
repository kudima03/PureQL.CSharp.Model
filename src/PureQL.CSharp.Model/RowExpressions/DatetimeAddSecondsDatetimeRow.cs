using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime@row</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeRow : IOperator
{
    public DatetimeAddSecondsDatetimeRow(DatetimeRow left, DecimalRow right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeRow Left { get; }

    public DecimalRow Right { get; }

    public IType Type => new TypeDatetime();
}
