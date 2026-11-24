using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfQuarter.datetime@row</c>.</summary>
public sealed record StartOfQuarterDatetimeRow : IOperator
{
    public StartOfQuarterDatetimeRow(DatetimeRow operand, StringRow? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeRow Operand { get; }

    public StringRow? Zone { get; }

    public IType Type => new TypeDatetime();
}
