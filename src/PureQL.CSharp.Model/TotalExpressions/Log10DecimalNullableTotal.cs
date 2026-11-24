using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>log10.decimal.nullable@total</c>.</summary>
public sealed record Log10DecimalNullableTotal : IOperator
{
    public Log10DecimalNullableTotal(IntegerNullableOrDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableTotal Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
