namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record NotEqualBooleanGroup
{
    public NotEqualBooleanGroup(BooleanNullableGroup left, BooleanNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableGroup Left { get; }

    public BooleanNullableGroup Right { get; }
}
