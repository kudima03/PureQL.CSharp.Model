using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>dateFromParts.date.nullable@projection</c>.</summary>
public sealed record DateFromPartsDateNullableProjection : IOperator
{
    public DateFromPartsDateNullableProjection(
        IntegerNullableProjection year,
        IntegerNullableProjection month,
        IntegerNullableProjection day
    )
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public IntegerNullableProjection Year { get; }

    public IntegerNullableProjection Month { get; }

    public IntegerNullableProjection Day { get; }

    public IType Type => new TypeDateNullable();
}
