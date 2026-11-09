using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>round.integer.nullable@projection</c>.</summary>
public sealed record RoundIntegerNullableProjection : IOperator
{
    public RoundIntegerNullableProjection(
        IntegerNullableOrDecimalNullableProjection operand
    )
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
