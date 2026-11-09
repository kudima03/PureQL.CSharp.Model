using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>notEqual.uuid@total</c>.</summary>
public sealed record NotEqualUuidTotal : IOperator
{
    public NotEqualUuidTotal(UuidNullableTotal left, UuidNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableTotal Left { get; }

    public UuidNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
