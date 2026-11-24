using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetimeAddMonths.datetime.nullable@total</c>.</summary>
public sealed record DatetimeAddMonthsDatetimeNullableTotal : IOperator
{
    public DatetimeAddMonthsDatetimeNullableTotal(
        DatetimeNullableTotal operand,
        IntegerNullableTotal months,
        StringNullableTotal? zone = null
    )
    {
        Operand = operand;
        Months = months;
        Zone = zone;
    }

    public DatetimeNullableTotal Operand { get; }

    public IntegerNullableTotal Months { get; }

    public StringNullableTotal? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
