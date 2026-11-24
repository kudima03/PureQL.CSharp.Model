using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asBoolean.boolean.nullable@row</c>.</summary>
public sealed record AsBooleanBooleanNullableRow : IOperator
{
    public AsBooleanBooleanNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeBooleanNullable();
}
