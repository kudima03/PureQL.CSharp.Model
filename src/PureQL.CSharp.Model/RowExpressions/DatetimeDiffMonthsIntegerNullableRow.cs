using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetimeDiffMonths.integer.nullable@row</c>.</summary>
public sealed record DatetimeDiffMonthsIntegerNullableRow : IOperator
{
    public DatetimeDiffMonthsIntegerNullableRow(
        DatetimeNullableRow left,
        DatetimeNullableRow right,
        StringNullableRow? zone = null
    )
    {
        Left = left;
        Right = right;
        Zone = zone;
    }

    public DatetimeNullableRow Left { get; }

    public DatetimeNullableRow Right { get; }

    public StringNullableRow? Zone { get; }

    public IType Type => new TypeIntegerNullable();
}
