namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record EqualStringGroup
{
    public EqualStringGroup(StringNullableGroup left, StringNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableGroup Left { get; }

    public StringNullableGroup Right { get; }
}
