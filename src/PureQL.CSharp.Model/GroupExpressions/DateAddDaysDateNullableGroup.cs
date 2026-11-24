using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dateAddDays.date.nullable@group</c>.</summary>
public sealed record DateAddDaysDateNullableGroup : IOperator
{
    public DateAddDaysDateNullableGroup(
        DateNullableGroup operand,
        IntegerNullableGroup days
    )
    {
        Operand = operand;
        Days = days;
    }

    public DateNullableGroup Operand { get; }

    public IntegerNullableGroup Days { get; }

    public IType Type => new TypeDateNullable();
}
