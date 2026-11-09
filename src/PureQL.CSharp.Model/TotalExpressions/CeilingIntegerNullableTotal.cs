using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>ceiling.integer.nullable@total</c>.</summary>
public sealed record CeilingIntegerNullableTotal : IOperator
{
    public CeilingIntegerNullableTotal(IntegerNullableOrDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
