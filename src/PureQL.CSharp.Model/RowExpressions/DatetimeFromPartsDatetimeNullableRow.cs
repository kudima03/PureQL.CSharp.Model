using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetimeFromParts.datetime.nullable@row</c>.</summary>
public sealed record DatetimeFromPartsDatetimeNullableRow : IOperator
{
    public DatetimeFromPartsDatetimeNullableRow(
        DateNullableRow date,
        TimeNullableRow time,
        StringNullableRow? zone = null
    )
    {
        Date = date;
        Time = time;
        Zone = zone;
    }

    public DateNullableRow Date { get; }

    public TimeNullableRow Time { get; }

    public StringNullableRow? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
