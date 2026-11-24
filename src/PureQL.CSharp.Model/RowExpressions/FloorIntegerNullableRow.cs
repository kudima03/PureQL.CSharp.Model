using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>floor.integer.nullable@row</c>.</summary>
public sealed record FloorIntegerNullableRow : IOperator
{
    public FloorIntegerNullableRow(DeclaresDecimalNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
