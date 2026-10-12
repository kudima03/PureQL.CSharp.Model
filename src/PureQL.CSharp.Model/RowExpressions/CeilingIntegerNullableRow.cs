using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CeilingIntegerNullableRow : IOperator
{
    public CeilingIntegerNullableRow(DecimalNullableRow operand)
    {
        Operand = operand;
    }

    public DecimalNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
