using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asString.uuid.string.nullable@total</c>.</summary>
public sealed record AsStringUuidStringNullableTotal : IOperator
{
    public AsStringUuidStringNullableTotal(DeclaresUuidNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresUuidNullableTotal Operand { get; }

    public IType Type => new TypeStringNullable();
}
