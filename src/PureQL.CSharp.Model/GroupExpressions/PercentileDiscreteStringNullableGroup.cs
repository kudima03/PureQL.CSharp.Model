using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileDiscrete.string.nullable@group</c>.</summary>
public sealed record PercentileDiscreteStringNullableGroup : IOperator
{
    public PercentileDiscreteStringNullableGroup(
        StringNullableRow selector,
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

    public StringNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeStringNullable();
}
