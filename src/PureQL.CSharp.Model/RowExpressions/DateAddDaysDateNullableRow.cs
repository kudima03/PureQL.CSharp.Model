using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dateAddDays.date.nullable@row</c>.</summary>
public sealed record DateAddDaysDateNullableRow : IOperator
{
    public DateAddDaysDateNullableRow(DateNullableRow operand, IntegerNullableRow days)
    {
        Operand = operand;
        Days = days;
    }

    public DateNullableRow Operand { get; }

    public IntegerNullableRow Days { get; }

    public IType Type => new TypeDateNullable();
}
