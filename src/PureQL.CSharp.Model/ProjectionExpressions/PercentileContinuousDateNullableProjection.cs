using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentileContinuous.date.nullable@projection</c>.</summary>
public sealed record PercentileContinuousDateNullableProjection : IOperator
{
    public PercentileContinuousDateNullableProjection(
        DateNullableRow selector,
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

    public DateNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDateNullable();
}
