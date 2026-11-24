using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asNullable.uuid.nullable@projection</c>.</summary>
public sealed record AsNullableUuidNullableProjection : IOperator
{
    public AsNullableUuidNullableProjection(UuidProjection operand)
    {
        Operand = operand;
    }

    public UuidProjection Operand { get; }

    public IType Type => new TypeUuidNullable();
}
