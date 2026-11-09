using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>integerDivide.integer@row</c>.</summary>
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
