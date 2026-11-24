using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asString.uuid.string.nullable@projection</c>.</summary>
public sealed record AsStringUuidStringNullableProjection : IOperator
{
    public AsStringUuidStringNullableProjection(DeclaresUuidNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresUuidNullableProjection Operand { get; }

    public IType Type => new TypeStringNullable();
}
