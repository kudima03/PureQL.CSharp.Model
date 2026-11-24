using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>ceiling.integer.nullable@total</c>.</summary>
public sealed record CeilingIntegerNullableTotal : IOperator
{
    public CeilingIntegerNullableTotal(DeclaresDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
