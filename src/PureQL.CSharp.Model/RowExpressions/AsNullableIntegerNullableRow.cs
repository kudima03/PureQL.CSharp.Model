using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asNullable.integer.nullable@row</c>.</summary>
public sealed record AsNullableIntegerNullableRow : IOperator
{
    public AsNullableIntegerNullableRow(IntegerRow operand)
    {
        Operand = operand;
    }

    public IntegerRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
