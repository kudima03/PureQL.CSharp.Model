using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greaterThan.uuid@total</c>.</summary>
public sealed record GreaterThanUuidTotal : IOperator
{
    public GreaterThanUuidTotal(UuidNullableTotal left, UuidNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableTotal Left { get; }

    public UuidNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
