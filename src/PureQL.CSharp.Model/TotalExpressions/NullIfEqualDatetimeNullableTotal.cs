using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>nullIfEqual.datetime.nullable@total</c>.</summary>
public sealed record NullIfEqualDatetimeNullableTotal : IOperator
{
    public NullIfEqualDatetimeNullableTotal(
        DatetimeNullableTotal left,
        DatetimeNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableTotal Left { get; }

    public DatetimeNullableTotal Right { get; }

    public IType Type => new TypeDatetimeNullable();
}
