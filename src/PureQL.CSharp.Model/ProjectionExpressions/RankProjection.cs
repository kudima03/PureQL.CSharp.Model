using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>rank@projection</c>.</summary>
public sealed record RankProjection : IOperator
{
    public RankProjection(OrderedWindow over)
    {
        Over = over;
    }

    public OrderedWindow Over { get; }

    public IType Type => new TypeInteger();
}
