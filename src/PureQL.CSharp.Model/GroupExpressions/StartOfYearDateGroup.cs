using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfYear.date@group</c>.</summary>
public sealed record StartOfYearDateGroup : IOperator
{
    public StartOfYearDateGroup(DateGroup operand)
    {
        Operand = operand;
    }

    public DateGroup Operand { get; }

    public IType Type => new TypeDate();
}
