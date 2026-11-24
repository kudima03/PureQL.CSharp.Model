using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>sign.integer.nullable@total</c>.</summary>
public sealed record SignIntegerNullableTotal : IOperator
{
    public SignIntegerNullableTotal(IntegerNullableOrDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
