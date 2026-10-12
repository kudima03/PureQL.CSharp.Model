using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record EqualDatetimeTotal : IOperator
{
    public EqualDatetimeTotal(DatetimeNullableTotal left, DatetimeNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableTotal Left { get; }

    public DatetimeNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
