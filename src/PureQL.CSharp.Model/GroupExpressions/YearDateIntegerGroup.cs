using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>year.date.integer@group</c>.</summary>
public sealed record YearDateIntegerGroup : IOperator
{
    public YearDateIntegerGroup(DateGroup operand)
    {
        Operand = operand;
    }

    public DateGroup Operand { get; }

    public IType Type => new TypeInteger();
}
