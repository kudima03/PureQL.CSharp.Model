using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dateAddMonths.date.nullable@group</c>.</summary>
public sealed record DateAddMonthsDateNullableGroup : IOperator
{
    public DateAddMonthsDateNullableGroup(
        DateNullableGroup operand,
        IntegerNullableGroup months
    )
    {
        Operand = operand;
        Months = months;
    }

    public DateNullableGroup Operand { get; }

    public IntegerNullableGroup Months { get; }

    public IType Type => new TypeDateNullable();
}
