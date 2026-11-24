using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>dateAddDays.date.nullable@total</c>.</summary>
public sealed record DateAddDaysDateNullableTotal : IOperator
{
    public DateAddDaysDateNullableTotal(
        DateNullableTotal operand,
        IntegerNullableTotal days
    )
    {
        Operand = operand;
        Days = days;
    }

    public DateNullableTotal Operand { get; }

    public IntegerNullableTotal Days { get; }

    public IType Type => new TypeDateNullable();
}
