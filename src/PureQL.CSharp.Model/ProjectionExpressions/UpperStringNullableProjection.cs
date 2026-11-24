using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>upper.string.nullable@projection</c>.</summary>
public sealed record UpperStringNullableProjection : IOperator
{
    public UpperStringNullableProjection(DeclaresStringNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeStringNullable();
}
