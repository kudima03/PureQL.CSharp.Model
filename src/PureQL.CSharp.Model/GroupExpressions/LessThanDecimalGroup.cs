namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record LessThanDecimalGroup
{
    public LessThanDecimalGroup(DecimalNullableGroup left, DecimalNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }
}
