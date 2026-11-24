using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>length.integer.nullable@row</c>.</summary>
public sealed record LengthIntegerNullableRow : IOperator
{
    public LengthIntegerNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
