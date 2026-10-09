namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record GreaterThanOrEqualStringGroup
{
    public GreaterThanOrEqualStringGroup(
        StringNullableGroup left,
        StringNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public StringNullableGroup Left { get; }

    public StringNullableGroup Right { get; }
}
