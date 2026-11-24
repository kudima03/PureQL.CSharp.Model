using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetimeFromParts.datetime.nullable@group</c>.</summary>
public sealed record DatetimeFromPartsDatetimeNullableGroup : IOperator
{
    public DatetimeFromPartsDatetimeNullableGroup(
        DateNullableGroup date,
        TimeNullableGroup time,
        StringNullableGroup? zone = null
    )
    {
        Date = date;
        Time = time;
        Zone = zone;
    }

    public DateNullableGroup Date { get; }

    public TimeNullableGroup Time { get; }

    public StringNullableGroup? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
