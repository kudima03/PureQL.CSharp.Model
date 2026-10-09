namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record GreaterThanOrEqualDatetimeGroup
{
    public GreaterThanOrEqualDatetimeGroup(
        DatetimeNullableGroup left,
        DatetimeNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableGroup Left { get; }

    public DatetimeNullableGroup Right { get; }
}
