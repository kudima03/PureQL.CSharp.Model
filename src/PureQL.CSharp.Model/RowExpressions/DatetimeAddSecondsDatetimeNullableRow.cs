using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime.nullable@row</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeNullableRow : IOperator
{
    public DatetimeAddSecondsDatetimeNullableRow(
        DatetimeNullableRow operand,
        DecimalNullableRow seconds
    )
    {
        Operand = operand;
        Seconds = seconds;
    }

    public DatetimeNullableRow Operand { get; }

    public DecimalNullableRow Seconds { get; }

    public IType Type => new TypeDatetimeNullable();
}
