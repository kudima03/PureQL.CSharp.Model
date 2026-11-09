using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>notEqual.date@total</c>.</summary>
public sealed record NotEqualDateTotal : IOperator
{
    public NotEqualDateTotal(DateNullableTotal left, DateNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableTotal Left { get; }

    public DateNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
