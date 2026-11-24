using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dateFromParts.date@group</c>.</summary>
public sealed record DateFromPartsDateGroup : IOperator
{
    public DateFromPartsDateGroup(IntegerGroup year, IntegerGroup month, IntegerGroup day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public IntegerGroup Year { get; }

    public IntegerGroup Month { get; }

    public IntegerGroup Day { get; }

    public IType Type => new TypeDate();
}
