using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>average.time@projection</c>.</summary>
public sealed record AverageTimeProjection : IOperator
{
    public AverageTimeProjection(TimeRow selector)
    {
        Selector = selector;
    }

    public TimeRow Selector { get; }

    public IType Type => new TypeTime();
}
