using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentileContinuous.time@projection</c>.</summary>
public sealed record PercentileContinuousTimeProjection : IOperator
{
    public PercentileContinuousTimeProjection(
        TimeRow selector,
        Fraction fraction,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public Window? Over { get; }

    public TimeRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeTime();
}
