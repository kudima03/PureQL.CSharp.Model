using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record FloorIntegerNullableRow : IOperator
{
    public FloorIntegerNullableRow(DecimalNullableRow operand)
    {
        Operand = operand;
    }

    public DecimalNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
