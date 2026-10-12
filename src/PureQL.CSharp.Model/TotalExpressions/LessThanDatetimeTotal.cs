using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record LessThanDatetimeTotal : IOperator
{
    public LessThanDatetimeTotal(DatetimeNullableTotal left, DatetimeNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableTotal Left { get; }

    public DatetimeNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
