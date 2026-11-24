using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>percentileDiscrete.boolean.nullable@total</c>.</summary>
public sealed record PercentileDiscreteBooleanNullableTotal : IOperator
{
    public PercentileDiscreteBooleanNullableTotal(
        BooleanNullableRow selector,
        Fraction fraction,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
        Fraction = fraction;
    }

    public BooleanRow? Predicate { get; }

    public BooleanNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeBooleanNullable();
}
