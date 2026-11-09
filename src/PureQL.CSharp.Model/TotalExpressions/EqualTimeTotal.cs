using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>equal.time@total</c>.</summary>
public sealed record EqualTimeTotal : IOperator
{
    public EqualTimeTotal(TimeNullableTotal left, TimeNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableTotal Left { get; }

    public TimeNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
