using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record CeilingIntegerNullableTotal : IOperator
{
    public CeilingIntegerNullableTotal(DecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public DecimalNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
