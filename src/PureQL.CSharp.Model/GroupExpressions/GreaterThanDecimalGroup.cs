namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record GreaterThanDecimalGroup
{
    public GreaterThanDecimalGroup(DecimalNullableGroup left, DecimalNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }
}
