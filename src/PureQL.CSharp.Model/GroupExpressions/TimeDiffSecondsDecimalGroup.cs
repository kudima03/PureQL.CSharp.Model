using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record TimeDiffSecondsDecimalGroup : IOperator
{
    public TimeDiffSecondsDecimalGroup(TimeGroup left, TimeGroup right)
    {
        Left = left;
        Right = right;
    }

    public TimeGroup Left { get; }

    public TimeGroup Right { get; }

    public IType Type => new TypeDecimal();
}
