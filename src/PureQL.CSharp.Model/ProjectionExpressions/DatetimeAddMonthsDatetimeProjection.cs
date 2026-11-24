using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetimeAddMonths.datetime@projection</c>.</summary>
public sealed record DatetimeAddMonthsDatetimeProjection : IOperator
{
    public DatetimeAddMonthsDatetimeProjection(
        DatetimeProjection operand,
        IntegerProjection months,
        StringProjection? zone = null
    )
    {
        Operand = operand;
        Months = months;
        Zone = zone;
    }

    public DatetimeProjection Operand { get; }

    public IntegerProjection Months { get; }

    public StringProjection? Zone { get; }

    public IType Type => new TypeDatetime();
}
