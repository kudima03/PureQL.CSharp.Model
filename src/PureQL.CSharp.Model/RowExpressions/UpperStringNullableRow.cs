using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>upper.string.nullable@row</c>.</summary>
public sealed record UpperStringNullableRow : IOperator
{
    public UpperStringNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeStringNullable();
}
