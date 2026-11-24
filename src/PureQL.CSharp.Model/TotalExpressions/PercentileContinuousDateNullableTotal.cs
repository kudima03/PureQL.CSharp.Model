using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>percentileContinuous.date.nullable@total</c>.</summary>
public sealed record PercentileContinuousDateNullableTotal : IOperator
{
    public PercentileContinuousDateNullableTotal(
        DateNullableRow selector,
        Fraction fraction,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
        Fraction = fraction;
    }

    public BooleanRow? Predicate { get; }

    public DateNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDateNullable();
}
