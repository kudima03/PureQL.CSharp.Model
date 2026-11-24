using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asInteger.integer.nullable@projection</c>.</summary>
public sealed record AsIntegerIntegerNullableProjection : IOperator
{
    public AsIntegerIntegerNullableProjection(DeclaresStringNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
