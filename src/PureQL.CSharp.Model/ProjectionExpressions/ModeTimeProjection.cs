using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>mode.time@projection</c>.</summary>
public sealed record ModeTimeProjection : IOperator
{
    public ModeTimeProjection(TimeRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public TimeRow Selector { get; }

    public IType Type => new TypeTime();
}
