using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetimeFromParts.datetime.nullable@projection</c>.</summary>
public sealed record DatetimeFromPartsDatetimeNullableProjection : IOperator
{
    public DatetimeFromPartsDatetimeNullableProjection(
        DateNullableProjection date,
        TimeNullableProjection time,
        StringNullableProjection? zone = null
    )
    {
        Date = date;
        Time = time;
        Zone = zone;
    }

    public DateNullableProjection Date { get; }

    public TimeNullableProjection Time { get; }

    public StringNullableProjection? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
