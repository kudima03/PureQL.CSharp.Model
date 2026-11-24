using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>covariancePopulation.decimal@group</c>.</summary>
public sealed record CovariancePopulationDecimalGroup : IOperator
{
    public CovariancePopulationDecimalGroup(
        DecimalRow left,
        DecimalRow right,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Left = left;
        Right = right;
    }

    public AggregateOver Over { get; }

    public DecimalRow Left { get; }

    public DecimalRow Right { get; }

    public IType Type => new TypeDecimal();
}
