using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>dateFromParts.date.nullable@total</c>.</summary>
public sealed record DateFromPartsDateNullableTotal : IOperator
{
    public DateFromPartsDateNullableTotal(
        IntegerNullableTotal year,
        IntegerNullableTotal month,
        IntegerNullableTotal day
    )
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public IntegerNullableTotal Year { get; }

    public IntegerNullableTotal Month { get; }

    public IntegerNullableTotal Day { get; }

    public IType Type => new TypeDateNullable();
}
