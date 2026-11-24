using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentileDiscrete.datetime@projection</c>.</summary>
public sealed record PercentileDiscreteDatetimeProjection : IOperator
{
    public PercentileDiscreteDatetimeProjection(
        DatetimeRow selector,
        Fraction fraction,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public Window? Over { get; }

    public DatetimeRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDatetime();
}
