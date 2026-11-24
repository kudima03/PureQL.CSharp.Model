using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>atan.decimal.nullable@projection</c>.</summary>
public sealed record AtanDecimalNullableProjection : IOperator
{
    public AtanDecimalNullableProjection(
        IntegerNullableOrDecimalNullableProjection operand
    )
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableProjection Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
