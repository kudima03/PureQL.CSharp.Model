using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dayOfYear.date.integer.nullable@row</c>.</summary>
public sealed record DayOfYearDateIntegerNullableRow : IOperator
{
    public DayOfYearDateIntegerNullableRow(DeclaresDateNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
