using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>ln.decimal.nullable@projection</c>.</summary>
public sealed record LnDecimalNullableProjection : IOperator
{
    public LnDecimalNullableProjection(IntegerNullableOrDecimalNullableProjection operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableProjection Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
