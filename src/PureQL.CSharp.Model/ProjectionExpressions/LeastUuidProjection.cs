using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.uuid@projection</c>.</summary>
public sealed record LeastUuidProjection : IOperator
{
    public LeastUuidProjection(IEnumerable<UuidProjection> values)
    {
        Values = values;
    }

    public IEnumerable<UuidProjection> Values { get; }

    public IType Type => new TypeUuid();
}
