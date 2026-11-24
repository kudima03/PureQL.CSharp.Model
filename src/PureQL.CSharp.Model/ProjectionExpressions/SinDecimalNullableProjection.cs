using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>sin.decimal.nullable@projection</c>.</summary>
public sealed record SinDecimalNullableProjection : IOperator
{
    public SinDecimalNullableProjection(
        IntegerNullableOrDecimalNullableProjection operand
    )
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableProjection Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
