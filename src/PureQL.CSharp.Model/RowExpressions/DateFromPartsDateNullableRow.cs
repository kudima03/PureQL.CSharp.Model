using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dateFromParts.date.nullable@row</c>.</summary>
public sealed record DateFromPartsDateNullableRow : IOperator
{
    public DateFromPartsDateNullableRow(
        IntegerNullableRow year,
        IntegerNullableRow month,
        IntegerNullableRow day
    )
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public IntegerNullableRow Year { get; }

    public IntegerNullableRow Month { get; }

    public IntegerNullableRow Day { get; }

    public IType Type => new TypeDateNullable();
}
