namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record EqualBooleanGroup
{
    public EqualBooleanGroup(BooleanNullableGroup left, BooleanNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableGroup Left { get; }

    public BooleanNullableGroup Right { get; }
}
