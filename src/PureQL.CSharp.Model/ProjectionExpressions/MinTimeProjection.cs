using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>min.time@projection</c>.</summary>
public sealed record MinTimeProjection : IOperator
{
    public MinTimeProjection(TimeRow selector)
    {
        Selector = selector;
    }

    public TimeRow Selector { get; }

    public IType Type => new TypeTime();
}
