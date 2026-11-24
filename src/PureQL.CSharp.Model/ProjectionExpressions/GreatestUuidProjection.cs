using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.uuid@projection</c>.</summary>
public sealed record GreatestUuidProjection : IOperator
{
    public GreatestUuidProjection(IEnumerable<UuidProjection> values)
    {
        Values = values;
    }

    public IEnumerable<UuidProjection> Values { get; }

    public IType Type => new TypeUuid();
}
