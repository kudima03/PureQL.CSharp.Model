using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetimeAddMonths.datetime@row</c>.</summary>
public sealed record DatetimeAddMonthsDatetimeRow : IOperator
{
    public DatetimeAddMonthsDatetimeRow(
        DatetimeRow operand,
        IntegerRow months,
        StringRow? zone = null
    )
    {
        Operand = operand;
        Months = months;
        Zone = zone;
    }

    public DatetimeRow Operand { get; }

    public IntegerRow Months { get; }

    public StringRow? Zone { get; }

    public IType Type => new TypeDatetime();
}
