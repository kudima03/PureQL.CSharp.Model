using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.time@projection</c>.</summary>
public sealed record GreatestTimeProjection : IOperator
{
    public GreatestTimeProjection(IEnumerable<TimeProjection> values)
    {
        Values = values;
    }

    public IEnumerable<TimeProjection> Values { get; }

    public IType Type => new TypeTime();
}
