namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record LessThanStringGroup
{
    public LessThanStringGroup(StringNullableGroup left, StringNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableGroup Left { get; }

    public StringNullableGroup Right { get; }
}
