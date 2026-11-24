using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>sign.integer.nullable@projection</c>.</summary>
public sealed record SignIntegerNullableProjection : IOperator
{
    public SignIntegerNullableProjection(
        IntegerNullableOrDecimalNullableProjection operand
    )
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
