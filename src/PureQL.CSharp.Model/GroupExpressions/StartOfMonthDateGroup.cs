using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfMonth.date@group</c>.</summary>
public sealed record StartOfMonthDateGroup : IOperator
{
    public StartOfMonthDateGroup(DateGroup operand)
    {
        Operand = operand;
    }

    public DateGroup Operand { get; }

    public IType Type => new TypeDate();
}
