using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asInteger.integer.nullable@total</c>.</summary>
public sealed record AsIntegerIntegerNullableTotal : IOperator
{
    public AsIntegerIntegerNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
