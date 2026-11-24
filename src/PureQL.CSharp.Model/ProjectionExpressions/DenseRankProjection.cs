using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>denseRank@projection</c>.</summary>
public sealed record DenseRankProjection : IOperator
{
    public DenseRankProjection(OrderedWindow over)
    {
        Over = over;
    }

    public OrderedWindow Over { get; }

    public IType Type => new TypeInteger();
}
