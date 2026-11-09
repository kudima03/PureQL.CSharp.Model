using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime.nullable@total</c>.</summary>
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
