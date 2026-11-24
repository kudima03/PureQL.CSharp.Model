using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asUuid.uuid.nullable@projection</c>.</summary>
public sealed record AsUuidUuidNullableProjection : IOperator
{
    public AsUuidUuidNullableProjection(DeclaresStringNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeUuidNullable();
}
