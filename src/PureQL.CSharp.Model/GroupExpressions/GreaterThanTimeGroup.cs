namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record GreaterThanTimeGroup
{
    public GreaterThanTimeGroup(TimeNullableGroup left, TimeNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableGroup Left { get; }

    public TimeNullableGroup Right { get; }
}
