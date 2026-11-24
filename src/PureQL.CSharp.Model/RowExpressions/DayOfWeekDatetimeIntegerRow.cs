using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dayOfWeek.datetime.integer@row</c>.</summary>
public sealed record DayOfWeekDatetimeIntegerRow : IOperator
{
    public DayOfWeekDatetimeIntegerRow(DatetimeRow operand, StringRow? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeRow Operand { get; }

    public StringRow? Zone { get; }

    public IType Type => new TypeInteger();
}
