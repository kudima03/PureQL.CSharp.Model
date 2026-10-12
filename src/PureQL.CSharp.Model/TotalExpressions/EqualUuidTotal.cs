using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record EqualUuidTotal : IOperator
{
    public EqualUuidTotal(UuidNullableTotal left, UuidNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableTotal Left { get; }

    public UuidNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
