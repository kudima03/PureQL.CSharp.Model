using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record ModuloIntegerRow : IOperator
{
    public ModuloIntegerRow(IntegerRow left, IntegerRow right)
    {
        Left = left;
        Right = right;
    }

    public IntegerRow Left { get; }

    public IntegerRow Right { get; }

    public IType Type => new TypeInteger();
}
