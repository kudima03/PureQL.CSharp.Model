using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dateAddDays.date@group</c>.</summary>
public sealed record DateAddDaysDateGroup : IOperator
{
    public DateAddDaysDateGroup(DateGroup operand, IntegerGroup days)
    {
        Operand = operand;
        Days = days;
    }

    public DateGroup Operand { get; }

    public IntegerGroup Days { get; }

    public IType Type => new TypeDate();
}
