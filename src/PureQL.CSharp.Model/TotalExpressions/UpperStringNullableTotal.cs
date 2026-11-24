using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>upper.string.nullable@total</c>.</summary>
public sealed record UpperStringNullableTotal : IOperator
{
    public UpperStringNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeStringNullable();
}
