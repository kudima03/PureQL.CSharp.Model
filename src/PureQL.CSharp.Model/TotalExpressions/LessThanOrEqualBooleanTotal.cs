using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>lessThanOrEqual.boolean@total</c>.</summary>
public sealed record LessThanOrEqualBooleanTotal : IOperator
{
    public LessThanOrEqualBooleanTotal(
        BooleanNullableTotal left,
        BooleanNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableTotal Left { get; }

    public BooleanNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
