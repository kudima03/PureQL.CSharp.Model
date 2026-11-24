using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.uuid.nullable@projection</c>.</summary>
public sealed record GreatestUuidNullableProjection : IOperator
{
    public GreatestUuidNullableProjection(IEnumerable<UuidNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableProjection> Values { get; }

    public IType Type => new TypeUuidNullable();
}
