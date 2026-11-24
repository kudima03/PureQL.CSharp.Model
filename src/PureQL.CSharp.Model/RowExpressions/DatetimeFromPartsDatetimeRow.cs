using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetimeFromParts.datetime@row</c>.</summary>
public sealed record DatetimeFromPartsDatetimeRow : IOperator
{
    public DatetimeFromPartsDatetimeRow(
        DateRow date,
        TimeRow time,
        StringRow? zone = null
    )
    {
        Date = date;
        Time = time;
        Zone = zone;
    }

    public DateRow Date { get; }

    public TimeRow Time { get; }

    public StringRow? Zone { get; }

    public IType Type => new TypeDatetime();
}
