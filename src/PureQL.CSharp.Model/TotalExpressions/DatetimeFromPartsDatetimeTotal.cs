using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetimeFromParts.datetime@total</c>.</summary>
public sealed record DatetimeFromPartsDatetimeTotal : IOperator
{
    public DatetimeFromPartsDatetimeTotal(
        DateTotal date,
        TimeTotal time,
        StringTotal? zone = null
    )
    {
        Date = date;
        Time = time;
        Zone = zone;
    }

    public DateTotal Date { get; }

    public TimeTotal Time { get; }

    public StringTotal? Zone { get; }

    public IType Type => new TypeDatetime();
}
