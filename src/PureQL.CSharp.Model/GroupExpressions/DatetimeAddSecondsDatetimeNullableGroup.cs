namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DatetimeAddSecondsDatetimeNullableGroup
{
    public DatetimeAddSecondsDatetimeNullableGroup(
        DatetimeNullableGroup left,
        DecimalNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }
}
