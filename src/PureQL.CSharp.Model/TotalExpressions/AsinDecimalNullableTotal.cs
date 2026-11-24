using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asin.decimal.nullable@total</c>.</summary>
public sealed record AsinDecimalNullableTotal : IOperator
{
    public AsinDecimalNullableTotal(IntegerNullableOrDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableTotal Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
