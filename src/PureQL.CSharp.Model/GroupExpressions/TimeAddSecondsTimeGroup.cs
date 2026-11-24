using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>timeAddSeconds.time@group</c>.</summary>
public sealed record TimeAddSecondsTimeGroup : IOperator
{
    public TimeAddSecondsTimeGroup(TimeGroup operand, DecimalGroup seconds)
    {
        Operand = operand;
        Seconds = seconds;
    }

    public TimeGroup Operand { get; }

    public DecimalGroup Seconds { get; }

    public IType Type => new TypeTime();
}
