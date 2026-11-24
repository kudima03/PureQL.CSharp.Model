using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>tan.decimal.nullable@projection</c>.</summary>
public sealed record TanDecimalNullableProjection : IOperator
{
    public TanDecimalNullableProjection(
        IntegerNullableOrDecimalNullableProjection operand
    )
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableProjection Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
