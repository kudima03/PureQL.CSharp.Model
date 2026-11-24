using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfMinute.time@group</c>.</summary>
public sealed record StartOfMinuteTimeGroup : IOperator
{
    public StartOfMinuteTimeGroup(TimeGroup operand)
    {
        Operand = operand;
    }

    public TimeGroup Operand { get; }

    public IType Type => new TypeTime();
}
