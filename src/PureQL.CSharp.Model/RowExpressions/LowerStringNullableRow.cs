using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>lower.string.nullable@row</c>.</summary>
public sealed record LowerStringNullableRow : IOperator
{
    public LowerStringNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeStringNullable();
}
