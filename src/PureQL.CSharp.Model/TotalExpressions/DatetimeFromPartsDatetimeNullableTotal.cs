using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetimeFromParts.datetime.nullable@total</c>.</summary>
public sealed record DatetimeFromPartsDatetimeNullableTotal : IOperator
{
    public DatetimeFromPartsDatetimeNullableTotal(
        DateNullableTotal date,
        TimeNullableTotal time,
        StringNullableTotal? zone = null
    )
    {
        Date = date;
        Time = time;
        Zone = zone;
    }

    public DateNullableTotal Date { get; }

    public TimeNullableTotal Time { get; }

    public StringNullableTotal? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
