using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greaterThanOrEqual.date@total</c>.</summary>
public sealed record GreaterThanOrEqualDateTotal : IOperator
{
    public GreaterThanOrEqualDateTotal(DateNullableTotal left, DateNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableTotal Left { get; }

    public DateNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
