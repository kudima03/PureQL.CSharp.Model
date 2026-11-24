using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>log.decimal.nullable@row</c>.</summary>
public sealed record LogDecimalNullableRow : IOperator
{
    public LogDecimalNullableRow(DecimalNullableRow operand, DecimalNullableRow @base)
    {
        Operand = operand;
        Base = @base;
    }

    public DecimalNullableRow Operand { get; }

    public DecimalNullableRow Base { get; }

    public IType Type => new TypeDecimalNullable();
}
