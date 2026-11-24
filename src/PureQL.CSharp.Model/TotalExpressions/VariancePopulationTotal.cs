using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>variancePopulation@total</c>.</summary>
public sealed record VariancePopulationTotal : IOperator
{
    public VariancePopulationTotal(
        DecimalNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public DecimalNullableRow Selector { get; }

    public IType Type => new TypeDecimalNullable();
}
