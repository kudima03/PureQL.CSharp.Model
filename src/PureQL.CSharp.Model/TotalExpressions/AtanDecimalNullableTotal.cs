using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>atan.decimal.nullable@total</c>.</summary>
public sealed record AtanDecimalNullableTotal : IOperator
{
    public AtanDecimalNullableTotal(IntegerNullableOrDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableTotal Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
