using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime@projection</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeProjection : IOperator
{
    public DatetimeAddSecondsDatetimeProjection(
        DatetimeProjection left,
        DecimalProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeProjection Left { get; }

    public DecimalProjection Right { get; }

    public IType Type => new TypeDatetime();
}
