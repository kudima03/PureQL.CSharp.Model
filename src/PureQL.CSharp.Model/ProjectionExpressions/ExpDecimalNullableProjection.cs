using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>exp.decimal.nullable@projection</c>.</summary>
public sealed record ExpDecimalNullableProjection : IOperator
{
    public ExpDecimalNullableProjection(
        IntegerNullableOrDecimalNullableProjection operand
    )
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableProjection Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
