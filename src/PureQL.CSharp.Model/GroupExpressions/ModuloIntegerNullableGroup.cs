namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record ModuloIntegerNullableGroup
{
    public ModuloIntegerNullableGroup(
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
