using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dateAddMonths.date.nullable@row</c>.</summary>
public sealed record DateAddMonthsDateNullableRow : IOperator
{
    public DateAddMonthsDateNullableRow(
        DateNullableRow operand,
        IntegerNullableRow months
    )
    {
        Operand = operand;
        Months = months;
    }

    public DateNullableRow Operand { get; }

    public IntegerNullableRow Months { get; }

    public IType Type => new TypeDateNullable();
}
