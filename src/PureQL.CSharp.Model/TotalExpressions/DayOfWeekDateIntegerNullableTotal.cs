using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>dayOfWeek.date.integer.nullable@total</c>.</summary>
public sealed record DayOfWeekDateIntegerNullableTotal : IOperator
{
    public DayOfWeekDateIntegerNullableTotal(DeclaresDateNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
