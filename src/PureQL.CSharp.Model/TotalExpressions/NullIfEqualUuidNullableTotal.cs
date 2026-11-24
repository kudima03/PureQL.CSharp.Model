using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>nullIfEqual.uuid.nullable@total</c>.</summary>
public sealed record NullIfEqualUuidNullableTotal : IOperator
{
    public NullIfEqualUuidNullableTotal(UuidNullableTotal left, UuidNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableTotal Left { get; }

    public UuidNullableTotal Right { get; }

    public IType Type => new TypeUuidNullable();
}
