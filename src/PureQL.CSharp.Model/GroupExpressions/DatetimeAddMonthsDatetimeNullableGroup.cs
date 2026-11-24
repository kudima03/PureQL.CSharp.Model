using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetimeAddMonths.datetime.nullable@group</c>.</summary>
public sealed record DatetimeAddMonthsDatetimeNullableGroup : IOperator
{
    public DatetimeAddMonthsDatetimeNullableGroup(
        DatetimeNullableGroup operand,
        IntegerNullableGroup months,
        StringNullableGroup? zone = null
    )
    {
        Operand = operand;
        Months = months;
        Zone = zone;
    }

    public DatetimeNullableGroup Operand { get; }

    public IntegerNullableGroup Months { get; }

    public StringNullableGroup? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
