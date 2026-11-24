using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentileContinuous.date@projection</c>.</summary>
public sealed record PercentileContinuousDateProjection : IOperator
{
    public PercentileContinuousDateProjection(
        DateRow selector,
        Fraction fraction,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public Window? Over { get; }

    public DateRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDate();
}
