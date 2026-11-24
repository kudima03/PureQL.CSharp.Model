using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetimeDiffMonths.integer.nullable@projection</c>.</summary>
public sealed record DatetimeDiffMonthsIntegerNullableProjection : IOperator
{
    public DatetimeDiffMonthsIntegerNullableProjection(
        DatetimeNullableProjection left,
        DatetimeNullableProjection right,
        StringNullableProjection? zone = null
    )
    {
        Left = left;
        Right = right;
        Zone = zone;
    }

    public DatetimeNullableProjection Left { get; }

    public DatetimeNullableProjection Right { get; }

    public StringNullableProjection? Zone { get; }

    public IType Type => new TypeIntegerNullable();
}
