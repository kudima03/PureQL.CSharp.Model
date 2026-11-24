using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentileDiscrete.decimal@projection</c>.</summary>
public sealed record PercentileDiscreteDecimalProjection : IOperator
{
    public PercentileDiscreteDecimalProjection(
        DeclaresDecimalRow selector,
        Fraction fraction,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public Window? Over { get; }

    public DeclaresDecimalRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDecimal();
}
