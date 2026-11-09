using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>equal.boolean@total</c>.</summary>
public sealed record EqualBooleanTotal : IOperator
{
    public EqualBooleanTotal(BooleanNullableTotal left, BooleanNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableTotal Left { get; }

    public BooleanNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
