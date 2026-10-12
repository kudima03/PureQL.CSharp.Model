using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record RoundIntegerNullableTotal : IOperator
{
    public RoundIntegerNullableTotal(DecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public DecimalNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
