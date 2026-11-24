using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfMonth.datetime@projection</c>.</summary>
public sealed record StartOfMonthDatetimeProjection : IOperator
{
    public StartOfMonthDatetimeProjection(
        DatetimeProjection operand,
        StringProjection? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeProjection Operand { get; }

    public StringProjection? Zone { get; }

    public IType Type => new TypeDatetime();
}
