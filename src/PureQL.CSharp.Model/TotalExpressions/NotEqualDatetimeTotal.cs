using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>notEqual.datetime@total</c>.</summary>
public sealed record NotEqualDatetimeTotal : IOperator
{
    public NotEqualDatetimeTotal(DatetimeNullableTotal left, DatetimeNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableTotal Left { get; }

    public DatetimeNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
