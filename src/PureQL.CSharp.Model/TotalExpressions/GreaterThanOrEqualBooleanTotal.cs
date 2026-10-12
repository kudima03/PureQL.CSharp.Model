using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record GreaterThanOrEqualBooleanTotal : IOperator
{
    public GreaterThanOrEqualBooleanTotal(
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
