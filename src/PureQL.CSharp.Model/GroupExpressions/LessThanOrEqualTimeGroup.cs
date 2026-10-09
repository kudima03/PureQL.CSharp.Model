namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record LessThanOrEqualTimeGroup
{
    public LessThanOrEqualTimeGroup(TimeNullableGroup left, TimeNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableGroup Left { get; }

    public TimeNullableGroup Right { get; }
}
