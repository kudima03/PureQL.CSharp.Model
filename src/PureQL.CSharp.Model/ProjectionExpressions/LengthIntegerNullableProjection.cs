using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>length.integer.nullable@projection</c>.</summary>
public sealed record LengthIntegerNullableProjection : IOperator
{
    public LengthIntegerNullableProjection(DeclaresStringNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
