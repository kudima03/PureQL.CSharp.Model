using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>lower.string.nullable@total</c>.</summary>
public sealed record LowerStringNullableTotal : IOperator
{
    public LowerStringNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeStringNullable();
}
