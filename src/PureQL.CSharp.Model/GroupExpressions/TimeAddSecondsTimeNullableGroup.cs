namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record TimeAddSecondsTimeNullableGroup
{
    public TimeAddSecondsTimeNullableGroup(
        TimeNullableGroup left,
        DecimalNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public TimeNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }
}
