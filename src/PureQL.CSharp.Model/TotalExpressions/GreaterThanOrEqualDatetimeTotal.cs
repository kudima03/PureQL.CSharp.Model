using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greaterThanOrEqual.datetime@total</c>.</summary>
public sealed record GreaterThanOrEqualDatetimeTotal : IOperator
{
    public GreaterThanOrEqualDatetimeTotal(
        DatetimeNullableTotal left,
        DatetimeNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableTotal Left { get; }

    public DatetimeNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
