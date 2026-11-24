using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>covariancePopulation.decimal.nullable@group</c>.</summary>
public sealed record CovariancePopulationDecimalNullableGroup : IOperator
{
    public CovariancePopulationDecimalNullableGroup(
        DecimalNullableRow left,
        DecimalNullableRow right,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Predicate = predicate;
        Over = over;
        Left = left;
        Right = right;
    }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }

    public DecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }

    public IType Type => new TypeDecimalNullable();
}
