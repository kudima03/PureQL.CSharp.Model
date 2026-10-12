using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceUuidProjection : IOperator
{
    public CoalesceUuidProjection(IEnumerable<UuidNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableProjection> Values { get; }

    public IType Type => new TypeUuid();
}
