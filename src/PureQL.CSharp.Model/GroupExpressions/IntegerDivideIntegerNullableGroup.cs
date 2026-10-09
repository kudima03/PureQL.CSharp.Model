namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IntegerDivideIntegerNullableGroup
{
    public IntegerDivideIntegerNullableGroup(
        IntegerNullableGroup left,
        IntegerNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableGroup Left { get; }

    public IntegerNullableGroup Right { get; }
}
