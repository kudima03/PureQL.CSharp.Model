namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record GreaterThanStringGroup
{
    public GreaterThanStringGroup(StringNullableGroup left, StringNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableGroup Left { get; }

    public StringNullableGroup Right { get; }
}
