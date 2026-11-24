using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dateFromParts.date@row</c>.</summary>
public sealed record DateFromPartsDateRow : IOperator
{
    public DateFromPartsDateRow(IntegerRow year, IntegerRow month, IntegerRow day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public IntegerRow Year { get; }

    public IntegerRow Month { get; }

    public IntegerRow Day { get; }

    public IType Type => new TypeDate();
}
