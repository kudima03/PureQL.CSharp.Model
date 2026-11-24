using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentileDiscrete.integer@projection</c>.</summary>
public sealed record PercentileDiscreteIntegerProjection : IOperator
{
    public PercentileDiscreteIntegerProjection(
        IntegerRow selector,
        Fraction fraction,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public Window? Over { get; }

    public IntegerRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeInteger();
}
