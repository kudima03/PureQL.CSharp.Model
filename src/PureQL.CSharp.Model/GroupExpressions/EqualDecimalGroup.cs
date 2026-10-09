namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record EqualDecimalGroup
{
    public EqualDecimalGroup(DecimalNullableGroup left, DecimalNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }
}
