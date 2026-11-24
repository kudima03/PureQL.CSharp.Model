using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>reverse.string.nullable@total</c>.</summary>
public sealed record ReverseStringNullableTotal : IOperator
{
    public ReverseStringNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeStringNullable();
}
