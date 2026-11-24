using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>quarter.date.integer.nullable@row</c>.</summary>
public sealed record QuarterDateIntegerNullableRow : IOperator
{
    public QuarterDateIntegerNullableRow(DeclaresDateNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
