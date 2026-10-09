namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DateDiffDaysIntegerGroup
{
    public DateDiffDaysIntegerGroup(DateGroup left, DateGroup right)
    {
        Left = left;
        Right = right;
    }

    public DateGroup Left { get; }

    public DateGroup Right { get; }
}
