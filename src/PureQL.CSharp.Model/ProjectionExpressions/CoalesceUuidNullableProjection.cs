using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceUuidNullableProjection : IOperator
{
    public CoalesceUuidNullableProjection(IEnumerable<UuidNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableProjection> Values { get; }

    public IType Type => new TypeUuidNullable();
}
