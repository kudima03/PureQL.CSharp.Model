using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentileDiscrete.boolean.nullable@projection</c>.</summary>
public sealed record PercentileDiscreteBooleanNullableProjection : IOperator
{
    public PercentileDiscreteBooleanNullableProjection(
        BooleanNullableRow selector,
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

    public BooleanNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeBooleanNullable();
}
