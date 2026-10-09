namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record GreaterThanOrEqualTimeGroup
{
    public GreaterThanOrEqualTimeGroup(TimeNullableGroup left, TimeNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableGroup Left { get; }

    public TimeNullableGroup Right { get; }
}
