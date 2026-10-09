namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DateAddDaysDateNullableGroup
{
    public DateAddDaysDateNullableGroup(
        DateNullableGroup left,
        IntegerNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DateNullableGroup Left { get; }

    public IntegerNullableGroup Right { get; }
}
