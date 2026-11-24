using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>percentileDiscrete.integer.nullable@total</c>.</summary>
public sealed record PercentileDiscreteIntegerNullableTotal : IOperator
{
    public PercentileDiscreteIntegerNullableTotal(
        IntegerNullableRow selector,
        Fraction fraction,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
        Fraction = fraction;
    }

    public BooleanRow? Predicate { get; }

    public IntegerNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeIntegerNullable();
}
