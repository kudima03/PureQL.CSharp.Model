using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfHour.time@group</c>.</summary>
public sealed record StartOfHourTimeGroup : IOperator
{
    public StartOfHourTimeGroup(TimeGroup operand)
    {
        Operand = operand;
    }

    public TimeGroup Operand { get; }

    public IType Type => new TypeTime();
}
