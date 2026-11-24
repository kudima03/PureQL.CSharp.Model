using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>percentileDiscrete.decimal.nullable@total</c>.</summary>
public sealed record PercentileDiscreteDecimalNullableTotal : IOperator
{
    public PercentileDiscreteDecimalNullableTotal(
        DecimalOrDecimalNullableRow selector,
        Fraction fraction,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
        Fraction = fraction;
    }

    public BooleanRow? Predicate { get; }

    public DecimalOrDecimalNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDecimalNullable();
}
