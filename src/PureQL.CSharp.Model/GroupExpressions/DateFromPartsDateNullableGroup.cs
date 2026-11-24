using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dateFromParts.date.nullable@group</c>.</summary>
public sealed record DateFromPartsDateNullableGroup : IOperator
{
    public DateFromPartsDateNullableGroup(
        IntegerNullableGroup year,
        IntegerNullableGroup month,
        IntegerNullableGroup day
    )
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public IntegerNullableGroup Year { get; }

    public IntegerNullableGroup Month { get; }

    public IntegerNullableGroup Day { get; }

    public IType Type => new TypeDateNullable();
}
