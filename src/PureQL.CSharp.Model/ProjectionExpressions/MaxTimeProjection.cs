using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>max.time@projection</c>.</summary>
public sealed record MaxTimeProjection : IOperator
{
    public MaxTimeProjection(TimeRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public TimeRow Selector { get; }

    public IType Type => new TypeTime();
}
