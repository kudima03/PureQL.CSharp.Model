using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentileDiscrete.uuid.nullable@projection</c>.</summary>
public sealed record PercentileDiscreteUuidNullableProjection : IOperator
{
    public PercentileDiscreteUuidNullableProjection(
        UuidNullableRow selector,
        Fraction fraction,
        BooleanRow? predicate = null,
        Window? over = null
    )
    {
        Predicate = predicate;
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public BooleanRow? Predicate { get; }

    public Window? Over { get; }

    public UuidNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeUuidNullable();
}
