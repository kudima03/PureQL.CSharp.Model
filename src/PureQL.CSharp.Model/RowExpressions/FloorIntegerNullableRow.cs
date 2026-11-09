using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>floor.integer.nullable@row</c>.</summary>
public sealed record FloorIntegerNullableRow : IOperator
{
    public FloorIntegerNullableRow(IntegerNullableOrDecimalNullableRow operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
