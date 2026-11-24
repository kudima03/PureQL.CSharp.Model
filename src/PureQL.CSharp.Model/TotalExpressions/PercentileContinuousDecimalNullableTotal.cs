using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>percentileContinuous.decimal.nullable@total</c>.</summary>
public sealed record PercentileContinuousDecimalNullableTotal : IOperator
{
    public PercentileContinuousDecimalNullableTotal(
        DecimalNullableRow selector,
        Fraction fraction,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
        Fraction = fraction;
    }

    public BooleanRow? Predicate { get; }

    public DecimalNullableRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDecimalNullable();
}
