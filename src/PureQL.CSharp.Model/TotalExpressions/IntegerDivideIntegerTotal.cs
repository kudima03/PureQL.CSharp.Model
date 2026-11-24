using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>integerDivide.integer@total</c>.</summary>
public sealed record IntegerDivideIntegerTotal : IOperator
{
    public IntegerDivideIntegerTotal(DecimalTotal left, DecimalTotal right)
    {
        Left = left;
        Right = right;
    }

    public DecimalTotal Left { get; }

    public DecimalTotal Right { get; }

    public IType Type => new TypeInteger();
}
