using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asInteger.integer.nullable@row</c>.</summary>
public sealed record AsIntegerIntegerNullableRow : IOperator
{
    public AsIntegerIntegerNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
