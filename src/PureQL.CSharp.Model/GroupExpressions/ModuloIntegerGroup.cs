namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record ModuloIntegerGroup
{
    public ModuloIntegerGroup(IntegerGroup left, IntegerGroup right)
    {
        Left = left;
        Right = right;
    }

    public IntegerGroup Left { get; }

    public IntegerGroup Right { get; }
}
