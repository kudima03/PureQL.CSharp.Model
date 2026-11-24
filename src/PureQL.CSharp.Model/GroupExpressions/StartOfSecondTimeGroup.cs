using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfSecond.time@group</c>.</summary>
public sealed record StartOfSecondTimeGroup : IOperator
{
    public StartOfSecondTimeGroup(TimeGroup operand)
    {
        Operand = operand;
    }

    public TimeGroup Operand { get; }

    public IType Type => new TypeTime();
}
