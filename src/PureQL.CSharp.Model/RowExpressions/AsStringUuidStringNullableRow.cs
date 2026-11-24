using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asString.uuid.string.nullable@row</c>.</summary>
public sealed record AsStringUuidStringNullableRow : IOperator
{
    public AsStringUuidStringNullableRow(DeclaresUuidNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresUuidNullableRow Operand { get; }

    public IType Type => new TypeStringNullable();
}
