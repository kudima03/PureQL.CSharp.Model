using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetimeDiffMonths.integer.nullable@group</c>.</summary>
public sealed record DatetimeDiffMonthsIntegerNullableGroup : IOperator
{
    public DatetimeDiffMonthsIntegerNullableGroup(
        DatetimeNullableGroup left,
        DatetimeNullableGroup right,
        StringNullableGroup? zone = null
    )
    {
        Left = left;
        Right = right;
        Zone = zone;
    }

    public DatetimeNullableGroup Left { get; }

    public DatetimeNullableGroup Right { get; }

    public StringNullableGroup? Zone { get; }

    public IType Type => new TypeIntegerNullable();
}
