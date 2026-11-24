using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentRank@projection</c>.</summary>
public sealed record PercentRankProjection : IOperator
{
    public PercentRankProjection(OrderedWindow over)
    {
        Over = over;
    }

    public OrderedWindow Over { get; }

    public IType Type => new TypeDecimal();
}
