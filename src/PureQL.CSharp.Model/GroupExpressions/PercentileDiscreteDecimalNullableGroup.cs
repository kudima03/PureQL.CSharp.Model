using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileDiscrete.decimal.nullable@group</c>.</summary>
public sealed record PercentileDiscreteDecimalNullableGroup : IOperator
{
    public PercentileDiscreteDecimalNullableGroup(
        DecimalOrDecimalNullableRow selector,
        Fraction fraction,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Predicate = predicate;
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }

    public DecimalOrDecimalNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDecimalNullable();
}
