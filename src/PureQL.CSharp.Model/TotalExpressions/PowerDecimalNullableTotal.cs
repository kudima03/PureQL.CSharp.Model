using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>power.decimal.nullable@total</c>.</summary>
public sealed record PowerDecimalNullableTotal : IOperator
{
    public PowerDecimalNullableTotal(
        DecimalNullableTotal operand,
        DecimalNullableTotal exponent
    )
    {
        Operand = operand;
        Exponent = exponent;
    }

    public DecimalNullableTotal Operand { get; }

    public DecimalNullableTotal Exponent { get; }

    public IType Type => new TypeDecimalNullable();
}
