using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>percentileDiscrete.uuid.nullable@total</c>.</summary>
public sealed record PercentileDiscreteUuidNullableTotal : IOperator
{
    public PercentileDiscreteUuidNullableTotal(
        UuidNullableRow selector,
        Fraction fraction,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
        Fraction = fraction;
    }

    public BooleanRow? Predicate { get; }

    public UuidNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeUuidNullable();
}
