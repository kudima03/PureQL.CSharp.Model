using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetimeDiffSeconds.decimal.nullable@total</c>.</summary>
public sealed record DatetimeDiffSecondsDecimalNullableTotal : IOperator
{
    public DatetimeDiffSecondsDecimalNullableTotal(
        DatetimeNullableTotal left,
        DatetimeNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableTotal Left { get; }

    public DatetimeNullableTotal Right { get; }

    public IType Type => new TypeDecimalNullable();
}
