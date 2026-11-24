using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetimeFromParts.datetime@projection</c>.</summary>
public sealed record DatetimeFromPartsDatetimeProjection : IOperator
{
    public DatetimeFromPartsDatetimeProjection(
        DateProjection date,
        TimeProjection time,
        StringProjection? zone = null
    )
    {
        Date = date;
        Time = time;
        Zone = zone;
    }

    public DateProjection Date { get; }

    public TimeProjection Time { get; }

    public StringProjection? Zone { get; }

    public IType Type => new TypeDatetime();
}
