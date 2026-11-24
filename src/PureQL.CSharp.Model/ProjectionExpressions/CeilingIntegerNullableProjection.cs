using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>ceiling.integer.nullable@projection</c>.</summary>
public sealed record CeilingIntegerNullableProjection : IOperator
{
    public CeilingIntegerNullableProjection(DeclaresDecimalNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
