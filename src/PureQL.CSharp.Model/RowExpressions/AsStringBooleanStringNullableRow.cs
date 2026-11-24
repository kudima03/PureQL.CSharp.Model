using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asString.boolean.string.nullable@row</c>.</summary>
public sealed record AsStringBooleanStringNullableRow : IOperator
{
    public AsStringBooleanStringNullableRow(DeclaresBooleanNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresBooleanNullableRow Operand { get; }

    public IType Type => new TypeStringNullable();
}
