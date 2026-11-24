using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>percentileDiscrete.time.nullable@total</c>.</summary>
public sealed record PercentileDiscreteTimeNullableTotal : IOperator
{
    public PercentileDiscreteTimeNullableTotal(
        TimeNullableRow selector,
        Fraction fraction,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
        Fraction = fraction;
    }

    public BooleanRow? Predicate { get; }

    public TimeNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeTimeNullable();
}
