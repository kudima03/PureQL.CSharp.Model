using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>round.integer.nullable@row</c>.</summary>
public sealed record RoundIntegerNullableRow : IOperator
{
    public RoundIntegerNullableRow(IntegerNullableOrDecimalNullableRow operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
