using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>round.integer.nullable@total</c>.</summary>
public sealed record RoundIntegerNullableTotal : IOperator
{
    public RoundIntegerNullableTotal(IntegerNullableOrDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
