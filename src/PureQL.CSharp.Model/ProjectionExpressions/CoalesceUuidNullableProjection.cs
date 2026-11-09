using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>coalesce.uuid.nullable@projection</c>.</summary>
public sealed record CoalesceUuidNullableProjection : IOperator
{
    public CoalesceUuidNullableProjection(
        IEnumerable<DeclaresUuidNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DeclaresUuidNullableProjection> Values { get; }

    public IType Type => new TypeUuidNullable();
}
