using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime.nullable@projection</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeNullableProjection : IOperator
{
    public DatetimeAddSecondsDatetimeNullableProjection(
        DatetimeNullableProjection operand,
        DecimalNullableProjection seconds
    )
    {
        Operand = operand;
        Seconds = seconds;
    }

    public DatetimeNullableProjection Operand { get; }

    public DecimalNullableProjection Seconds { get; }

    public IType Type => new TypeDatetimeNullable();
}
