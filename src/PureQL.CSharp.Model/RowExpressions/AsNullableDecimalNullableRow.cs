using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asNullable.decimal.nullable@row</c>.</summary>
public sealed record AsNullableDecimalNullableRow : IOperator
{
    public AsNullableDecimalNullableRow(DeclaresDecimalRow operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalRow Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
