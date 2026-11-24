using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dateAddMonths.date@group</c>.</summary>
public sealed record DateAddMonthsDateGroup : IOperator
{
    public DateAddMonthsDateGroup(DateGroup operand, IntegerGroup months)
    {
        Operand = operand;
        Months = months;
    }

    public DateGroup Operand { get; }

    public IntegerGroup Months { get; }

    public IType Type => new TypeDate();
}
