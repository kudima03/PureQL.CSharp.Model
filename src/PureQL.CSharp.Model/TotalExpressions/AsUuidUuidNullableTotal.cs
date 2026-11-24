using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asUuid.uuid.nullable@total</c>.</summary>
public sealed record AsUuidUuidNullableTotal : IOperator
{
    public AsUuidUuidNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeUuidNullable();
}
