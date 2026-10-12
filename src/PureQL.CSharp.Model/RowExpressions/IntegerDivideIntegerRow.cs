using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IntegerDivideIntegerRow : IOperator
{
    public IntegerDivideIntegerRow(IntegerRow left, IntegerRow right)
    {
        Left = left;
        Right = right;
    }

    public IntegerRow Left { get; }

    public IntegerRow Right { get; }

    public IType Type => new TypeInteger();
}
