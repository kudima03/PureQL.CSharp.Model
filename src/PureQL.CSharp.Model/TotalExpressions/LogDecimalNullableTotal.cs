using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>log.decimal.nullable@total</c>.</summary>
public sealed record LogDecimalNullableTotal : IOperator
{
    public LogDecimalNullableTotal(
        DecimalNullableTotal operand,
        DecimalNullableTotal @base
    )
    {
        Operand = operand;
        Base = @base;
    }

    public DecimalNullableTotal Operand { get; }

    public DecimalNullableTotal Base { get; }

    public IType Type => new TypeDecimalNullable();
}
