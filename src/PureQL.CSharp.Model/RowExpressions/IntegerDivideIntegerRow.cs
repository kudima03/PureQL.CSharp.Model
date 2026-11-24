using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>integerDivide.integer@row</c>.</summary>
public sealed record IntegerDivideIntegerRow : IOperator
{
    public IntegerDivideIntegerRow(DecimalRow left, DecimalRow right)
    {
        Left = left;
        Right = right;
    }

    public DecimalRow Left { get; }

    public DecimalRow Right { get; }

    public IType Type => new TypeInteger();
}
