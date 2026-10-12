using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record LessThanOrEqualUuidTotal : IOperator
{
    public LessThanOrEqualUuidTotal(UuidNullableTotal left, UuidNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableTotal Left { get; }

    public UuidNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
