using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asNullable.uuid.nullable@total</c>.</summary>
public sealed record AsNullableUuidNullableTotal : IOperator
{
    public AsNullableUuidNullableTotal(UuidTotal operand)
    {
        Operand = operand;
    }

    public UuidTotal Operand { get; }

    public IType Type => new TypeUuidNullable();
}
