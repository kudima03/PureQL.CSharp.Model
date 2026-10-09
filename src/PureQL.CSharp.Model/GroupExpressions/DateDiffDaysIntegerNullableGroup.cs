namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DateDiffDaysIntegerNullableGroup
{
    public DateDiffDaysIntegerNullableGroup(
        DateNullableGroup left,
        DateNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DateNullableGroup Left { get; }

    public DateNullableGroup Right { get; }
}
