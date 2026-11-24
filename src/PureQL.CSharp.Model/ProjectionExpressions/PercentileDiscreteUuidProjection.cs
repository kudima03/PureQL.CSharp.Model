using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentileDiscrete.uuid@projection</c>.</summary>
public sealed record PercentileDiscreteUuidProjection : IOperator
{
    public PercentileDiscreteUuidProjection(
        UuidRow selector,
        Fraction fraction,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public Window? Over { get; }

    public UuidRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeUuid();
}
