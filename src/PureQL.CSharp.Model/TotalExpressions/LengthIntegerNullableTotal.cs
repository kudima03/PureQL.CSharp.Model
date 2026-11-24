using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>length.integer.nullable@total</c>.</summary>
public sealed record LengthIntegerNullableTotal : IOperator
{
    public LengthIntegerNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
