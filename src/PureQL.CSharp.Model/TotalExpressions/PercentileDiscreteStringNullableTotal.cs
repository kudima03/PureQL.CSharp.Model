using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>percentileDiscrete.string.nullable@total</c>.</summary>
public sealed record PercentileDiscreteStringNullableTotal : IOperator
{
    public PercentileDiscreteStringNullableTotal(
        StringNullableRow selector,
        Fraction fraction,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
        Fraction = fraction;
    }

    public BooleanRow? Predicate { get; }

    public StringNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeStringNullable();
}
