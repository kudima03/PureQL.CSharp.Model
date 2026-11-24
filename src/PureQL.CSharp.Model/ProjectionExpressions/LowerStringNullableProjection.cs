using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>lower.string.nullable@projection</c>.</summary>
public sealed record LowerStringNullableProjection : IOperator
{
    public LowerStringNullableProjection(DeclaresStringNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeStringNullable();
}
