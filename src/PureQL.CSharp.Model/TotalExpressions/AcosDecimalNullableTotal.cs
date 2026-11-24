using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>acos.decimal.nullable@total</c>.</summary>
public sealed record AcosDecimalNullableTotal : IOperator
{
    public AcosDecimalNullableTotal(IntegerNullableOrDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableTotal Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
