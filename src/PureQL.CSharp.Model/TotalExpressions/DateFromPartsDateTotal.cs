using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>dateFromParts.date@total</c>.</summary>
public sealed record DateFromPartsDateTotal : IOperator
{
    public DateFromPartsDateTotal(IntegerTotal year, IntegerTotal month, IntegerTotal day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public IntegerTotal Year { get; }

    public IntegerTotal Month { get; }

    public IntegerTotal Day { get; }

    public IType Type => new TypeDate();
}
