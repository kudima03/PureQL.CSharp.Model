using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asDecimal.integer.decimal.nullable@total</c>.</summary>
public sealed record AsDecimalIntegerDecimalNullableTotal : IOperator
{
    public AsDecimalIntegerDecimalNullableTotal(DeclaresIntegerNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresIntegerNullableTotal Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
