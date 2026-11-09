using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>max.time@projection</c>.</summary>
public sealed record MaxTimeProjection : IOperator
{
    public MaxTimeProjection(TimeRow selector)
    {
        Selector = selector;
    }

    public TimeRow Selector { get; }

    public IType Type => new TypeTime();
}
