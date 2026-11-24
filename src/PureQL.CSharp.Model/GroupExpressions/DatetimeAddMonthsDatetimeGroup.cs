using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetimeAddMonths.datetime@group</c>.</summary>
public sealed record DatetimeAddMonthsDatetimeGroup : IOperator
{
    public DatetimeAddMonthsDatetimeGroup(
        DatetimeGroup operand,
        IntegerGroup months,
        StringGroup? zone = null
    )
    {
        Operand = operand;
        Months = months;
        Zone = zone;
    }

    public DatetimeGroup Operand { get; }

    public IntegerGroup Months { get; }

    public StringGroup? Zone { get; }

    public IType Type => new TypeDatetime();
}
