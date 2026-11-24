using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dayOfWeek.date.integer@row</c>.</summary>
public sealed record DayOfWeekDateIntegerRow : IOperator
{
    public DayOfWeekDateIntegerRow(DateRow operand)
    {
        Operand = operand;
    }

    public DateRow Operand { get; }

    public IType Type => new TypeInteger();
}
