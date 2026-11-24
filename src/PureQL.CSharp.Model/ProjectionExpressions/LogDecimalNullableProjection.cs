using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>log.decimal.nullable@projection</c>.</summary>
public sealed record LogDecimalNullableProjection : IOperator
{
    public LogDecimalNullableProjection(
        DecimalNullableProjection operand,
        DecimalNullableProjection @base
    )
    {
        Operand = operand;
        Base = @base;
    }

    public DecimalNullableProjection Operand { get; }

    public DecimalNullableProjection Base { get; }

    public IType Type => new TypeDecimalNullable();
}
