using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>cumulativeDistribution@projection</c>.</summary>
public sealed record CumulativeDistributionProjection : IOperator
{
    public CumulativeDistributionProjection(OrderedWindow over)
    {
        Over = over;
    }

    public OrderedWindow Over { get; }

    public IType Type => new TypeDecimal();
}
