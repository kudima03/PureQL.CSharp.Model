namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record NotEqualStringGroup
{
    public NotEqualStringGroup(StringNullableGroup left, StringNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableGroup Left { get; }

    public StringNullableGroup Right { get; }
}
