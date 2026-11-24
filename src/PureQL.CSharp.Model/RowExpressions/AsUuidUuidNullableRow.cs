using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asUuid.uuid.nullable@row</c>.</summary>
public sealed record AsUuidUuidNullableRow : IOperator
{
    public AsUuidUuidNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeUuidNullable();
}
