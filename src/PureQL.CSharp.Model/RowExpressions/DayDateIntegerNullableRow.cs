using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>day.date.integer.nullable@row</c>.</summary>
public sealed record DayDateIntegerNullableRow : IOperator
{
    public DayDateIntegerNullableRow(DeclaresDateNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
