namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record LessThanTimeGroup
{
    public LessThanTimeGroup(TimeNullableGroup left, TimeNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableGroup Left { get; }

    public TimeNullableGroup Right { get; }
}
