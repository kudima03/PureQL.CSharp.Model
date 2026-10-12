using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record LessThanUuidTotal : IOperator
{
    public LessThanUuidTotal(UuidNullableTotal left, UuidNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableTotal Left { get; }

    public UuidNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
