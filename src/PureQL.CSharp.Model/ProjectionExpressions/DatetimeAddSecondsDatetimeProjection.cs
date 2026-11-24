using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime@projection</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeProjection : IOperator
{
    public DatetimeAddSecondsDatetimeProjection(
        DatetimeProjection operand,
        DecimalProjection seconds
    )
    {
        Operand = operand;
        Seconds = seconds;
    }

    public DatetimeProjection Operand { get; }

    public DecimalProjection Seconds { get; }

    public IType Type => new TypeDatetime();
}
