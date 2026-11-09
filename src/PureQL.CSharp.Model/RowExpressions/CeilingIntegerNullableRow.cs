using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>ceiling.integer.nullable@row</c>.</summary>
public sealed record CeilingIntegerNullableRow : IOperator
{
    public CeilingIntegerNullableRow(IntegerNullableOrDecimalNullableRow operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
