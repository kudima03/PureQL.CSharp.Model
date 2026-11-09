using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>timeAddSeconds.time@group</c>.</summary>
public sealed record TimeAddSecondsTimeGroup : IOperator
{
    public TimeAddSecondsTimeGroup(TimeGroup left, DecimalGroup right)
    {
        Left = left;
        Right = right;
    }

    public TimeGroup Left { get; }

    public DecimalGroup Right { get; }

    public IType Type => new TypeTime();
}
