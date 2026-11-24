using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>reverse.string.nullable@projection</c>.</summary>
public sealed record ReverseStringNullableProjection : IOperator
{
    public ReverseStringNullableProjection(DeclaresStringNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeStringNullable();
}
