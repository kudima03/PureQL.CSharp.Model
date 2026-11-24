using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>sqrt.decimal.nullable@total</c>.</summary>
public sealed record SqrtDecimalNullableTotal : IOperator
{
    public SqrtDecimalNullableTotal(IntegerNullableOrDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableTotal Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
