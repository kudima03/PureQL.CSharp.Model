using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

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
