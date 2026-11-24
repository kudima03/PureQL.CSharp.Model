using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>dateFromParts.date@projection</c>.</summary>
public sealed record DateFromPartsDateProjection : IOperator
{
    public DateFromPartsDateProjection(
        IntegerProjection year,
        IntegerProjection month,
        IntegerProjection day
    )
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public IntegerProjection Year { get; }

    public IntegerProjection Month { get; }

    public IntegerProjection Day { get; }

    public IType Type => new TypeDate();
}
