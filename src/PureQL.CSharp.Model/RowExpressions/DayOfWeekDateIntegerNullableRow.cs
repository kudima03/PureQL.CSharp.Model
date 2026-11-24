using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dayOfWeek.date.integer.nullable@row</c>.</summary>
public sealed record DayOfWeekDateIntegerNullableRow : IOperator
{
    public DayOfWeekDateIntegerNullableRow(DeclaresDateNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
