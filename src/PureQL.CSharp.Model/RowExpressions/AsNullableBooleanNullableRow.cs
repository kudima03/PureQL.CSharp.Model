using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asNullable.boolean.nullable@row</c>.</summary>
public sealed record AsNullableBooleanNullableRow : IOperator
{
    public AsNullableBooleanNullableRow(BooleanRow operand)
    {
        Operand = operand;
    }

    public BooleanRow Operand { get; }

    public IType Type => new TypeBooleanNullable();
}
