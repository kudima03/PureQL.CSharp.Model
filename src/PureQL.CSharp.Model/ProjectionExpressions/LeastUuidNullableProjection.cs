using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.uuid.nullable@projection</c>.</summary>
public sealed record LeastUuidNullableProjection : IOperator
{
    public LeastUuidNullableProjection(IEnumerable<UuidNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableProjection> Values { get; }

    public IType Type => new TypeUuidNullable();
}
