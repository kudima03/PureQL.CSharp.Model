using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DatetimeDiffSecondsDecimalGroup : IOperator
{
    public DatetimeDiffSecondsDecimalGroup(DatetimeGroup left, DatetimeGroup right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeGroup Left { get; }

    public DatetimeGroup Right { get; }

    public IType Type => new TypeDecimal();
}
