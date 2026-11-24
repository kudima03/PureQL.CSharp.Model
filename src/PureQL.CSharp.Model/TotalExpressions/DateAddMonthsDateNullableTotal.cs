using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>dateAddMonths.date.nullable@total</c>.</summary>
public sealed record DateAddMonthsDateNullableTotal : IOperator
{
    public DateAddMonthsDateNullableTotal(
        DateNullableTotal operand,
        IntegerNullableTotal months
    )
    {
        Operand = operand;
        Months = months;
    }

    public DateNullableTotal Operand { get; }

    public IntegerNullableTotal Months { get; }

    public IType Type => new TypeDateNullable();
}
