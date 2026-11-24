using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>percentileContinuous.datetime.nullable@total</c>.</summary>
public sealed record PercentileContinuousDatetimeNullableTotal : IOperator
{
    public PercentileContinuousDatetimeNullableTotal(
        DatetimeNullableRow selector,
        Fraction fraction,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
        Fraction = fraction;
    }

    public BooleanRow? Predicate { get; }

    public DatetimeNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDatetimeNullable();
}
