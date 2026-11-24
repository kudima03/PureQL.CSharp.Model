using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetimeDiffMonths.integer@projection</c>.</summary>
public sealed record DatetimeDiffMonthsIntegerProjection : IOperator
{
    public DatetimeDiffMonthsIntegerProjection(
        DatetimeProjection left,
        DatetimeProjection right,
        StringProjection? zone = null
    )
    {
        Left = left;
        Right = right;
        Zone = zone;
    }

    public DatetimeProjection Left { get; }

    public DatetimeProjection Right { get; }

    public StringProjection? Zone { get; }

    public IType Type => new TypeInteger();
}
