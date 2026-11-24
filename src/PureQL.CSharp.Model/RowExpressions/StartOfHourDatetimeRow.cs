using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfHour.datetime@row</c>.</summary>
public sealed record StartOfHourDatetimeRow : IOperator
{
    public StartOfHourDatetimeRow(DatetimeRow operand, StringRow? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeRow Operand { get; }

    public StringRow? Zone { get; }

    public IType Type => new TypeDatetime();
}
