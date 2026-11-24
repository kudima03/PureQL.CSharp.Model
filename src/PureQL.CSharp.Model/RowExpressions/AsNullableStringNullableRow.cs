using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asNullable.string.nullable@row</c>.</summary>
public sealed record AsNullableStringNullableRow : IOperator
{
    public AsNullableStringNullableRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeStringNullable();
}
