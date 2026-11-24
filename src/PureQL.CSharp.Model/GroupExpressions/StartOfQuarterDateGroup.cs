using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfQuarter.date@group</c>.</summary>
public sealed record StartOfQuarterDateGroup : IOperator
{
    public StartOfQuarterDateGroup(DateGroup operand)
    {
        Operand = operand;
    }

    public DateGroup Operand { get; }

    public IType Type => new TypeDate();
}
