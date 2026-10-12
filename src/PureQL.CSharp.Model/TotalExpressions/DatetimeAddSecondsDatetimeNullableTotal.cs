using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record DatetimeAddSecondsDatetimeNullableTotal : IOperator
{
    public DatetimeAddSecondsDatetimeNullableTotal(
        DatetimeNullableTotal left,
        DecimalNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableTotal Left { get; }

    public DecimalNullableTotal Right { get; }

    public IType Type => new TypeDatetimeNullable();
}
