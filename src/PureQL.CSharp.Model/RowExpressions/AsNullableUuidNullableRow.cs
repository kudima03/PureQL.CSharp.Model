using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asNullable.uuid.nullable@row</c>.</summary>
public sealed record AsNullableUuidNullableRow : IOperator
{
    public AsNullableUuidNullableRow(UuidRow operand)
    {
        Operand = operand;
    }

    public UuidRow Operand { get; }

    public IType Type => new TypeUuidNullable();
}
