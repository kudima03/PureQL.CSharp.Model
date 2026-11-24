using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>covariancePopulation@total</c>.</summary>
public sealed record CovariancePopulationTotal : IOperator
{
    public CovariancePopulationTotal(
        DecimalNullableRow left,
        DecimalNullableRow right,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Left = left;
        Right = right;
    }

    public BooleanRow? Predicate { get; }

    public DecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }

    public IType Type => new TypeDecimalNullable();
}
