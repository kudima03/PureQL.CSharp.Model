using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.time@projection</c>.</summary>
public sealed record LeastTimeProjection : IOperator
{
    public LeastTimeProjection(IEnumerable<TimeProjection> values)
    {
        Values = values;
    }

    public IEnumerable<TimeProjection> Values { get; }

    public IType Type => new TypeTime();
}
