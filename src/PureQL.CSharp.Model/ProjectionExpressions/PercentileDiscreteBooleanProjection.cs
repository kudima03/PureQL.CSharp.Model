using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentileDiscrete.boolean@projection</c>.</summary>
public sealed record PercentileDiscreteBooleanProjection : IOperator
{
    public PercentileDiscreteBooleanProjection(
        BooleanRow selector,
        Fraction fraction,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public Window? Over { get; }

    public BooleanRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeBoolean();
}
