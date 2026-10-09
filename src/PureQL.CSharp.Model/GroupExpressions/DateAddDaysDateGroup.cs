namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DateAddDaysDateGroup
{
    public DateAddDaysDateGroup(DateGroup left, IntegerGroup right)
    {
        Left = left;
        Right = right;
    }

    public DateGroup Left { get; }

    public IntegerGroup Right { get; }
}
