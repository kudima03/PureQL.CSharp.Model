using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetimeFromParts.datetime@group</c>.</summary>
public sealed record DatetimeFromPartsDatetimeGroup : IOperator
{
    public DatetimeFromPartsDatetimeGroup(
        DateGroup date,
        TimeGroup time,
        StringGroup? zone = null
    )
    {
        Date = date;
        Time = time;
        Zone = zone;
    }

    public DateGroup Date { get; }

    public TimeGroup Time { get; }

    public StringGroup? Zone { get; }

    public IType Type => new TypeDatetime();
}
