using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime.nullable@total</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeNullableTotal : IOperator
{
    public DatetimeAddSecondsDatetimeNullableTotal(
        DatetimeNullableTotal operand,
        DecimalNullableTotal seconds
    )
    {
        Operand = operand;
        Seconds = seconds;
    }

    public DatetimeNullableTotal Operand { get; }

    public DecimalNullableTotal Seconds { get; }

    public IType Type => new TypeDatetimeNullable();
}
