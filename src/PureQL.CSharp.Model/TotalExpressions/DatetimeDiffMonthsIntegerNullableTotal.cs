using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetimeDiffMonths.integer.nullable@total</c>.</summary>
public sealed record DatetimeDiffMonthsIntegerNullableTotal : IOperator
{
    public DatetimeDiffMonthsIntegerNullableTotal(
        DatetimeNullableTotal left,
        DatetimeNullableTotal right,
        StringNullableTotal? zone = null
    )
    {
        Left = left;
        Right = right;
        Zone = zone;
    }

    public DatetimeNullableTotal Left { get; }

    public DatetimeNullableTotal Right { get; }

    public StringNullableTotal? Zone { get; }

    public IType Type => new TypeIntegerNullable();
}
