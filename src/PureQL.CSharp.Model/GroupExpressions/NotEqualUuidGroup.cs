namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record NotEqualUuidGroup
{
    public NotEqualUuidGroup(UuidNullableGroup left, UuidNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableGroup Left { get; }

    public UuidNullableGroup Right { get; }
}
