using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>reverse.string.nullable@row</c>.</summary>
public sealed record ReverseStringNullableRow : IOperator
{
    public ReverseStringNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeStringNullable();
}
