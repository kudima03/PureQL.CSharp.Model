using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>year.date.integer.nullable@row</c>.</summary>
public sealed record YearDateIntegerNullableRow : IOperator
{
    public YearDateIntegerNullableRow(DeclaresDateNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
