using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>integerDivide.integer@total</c>.</summary>
public sealed record IntegerDivideIntegerTotal : IOperator
{
    public IntegerDivideIntegerTotal(IntegerTotal left, IntegerTotal right)
    {
        Left = left;
        Right = right;
    }

    public IntegerTotal Left { get; }

    public IntegerTotal Right { get; }

    public IType Type => new TypeInteger();
}
