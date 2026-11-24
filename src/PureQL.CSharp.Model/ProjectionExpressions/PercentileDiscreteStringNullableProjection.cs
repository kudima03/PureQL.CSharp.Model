using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentileDiscrete.string.nullable@projection</c>.</summary>
public sealed record PercentileDiscreteStringNullableProjection : IOperator
{
    public PercentileDiscreteStringNullableProjection(
        StringNullableRow selector,
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

    public StringNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeStringNullable();
}
