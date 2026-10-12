using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record NotEqualBooleanTotal : IOperator
{
    public NotEqualBooleanTotal(BooleanNullableTotal left, BooleanNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableTotal Left { get; }

    public BooleanNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
