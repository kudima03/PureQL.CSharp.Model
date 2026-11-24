using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>trim.string.nullable@row</c>.</summary>
public sealed record TrimStringNullableRow : IOperator
{
    public TrimStringNullableRow(
        DeclaresStringNullableRow operand,
        IEnumerable<StringRow> removables
    )
    {
        Operand = operand;
        Removables = removables;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IEnumerable<StringRow> Removables { get; }

    public IType Type => new TypeStringNullable();
}
