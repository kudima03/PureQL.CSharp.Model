using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetimeAddMonths.datetime.nullable@row</c>.</summary>
public sealed record DatetimeAddMonthsDatetimeNullableRow : IOperator
{
    public DatetimeAddMonthsDatetimeNullableRow(
        DatetimeNullableRow operand,
        IntegerNullableRow months,
        StringNullableRow? zone = null
    )
    {
        Operand = operand;
        Months = months;
        Zone = zone;
    }

    public DatetimeNullableRow Operand { get; }

    public IntegerNullableRow Months { get; }

    public StringNullableRow? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
